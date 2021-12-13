using Dictionary.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Game : UserControl
    {
        MySqlConnection con;
        List<string> datas;
        List<string> rp;
        int countDown = 10, startTime = 3;
        SoundPlayer tickingSound, alarmSound, dingSound, buzzSound;
        int point = 0, lives = 3;

        public Game()
        {
            InitializeComponent();
            con = DBUtils.GetDBConnection();
            datas = new List<string>();
            rp = new List<string>();
            tickingSound = new SoundPlayer("ticking.wav");
            alarmSound = new SoundPlayer("alarm.wav");
            dingSound = new SoundPlayer("ding.wav");
            buzzSound = new SoundPlayer("buzzer.wav");
            Collapse();
        }

        void GetData()
        {
            datas.Clear();
            rp.Clear();
            string query = "select * from dictionary";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sword = myReader.GetString("word");

                    if (sword.Length <= 1 || sword.IndexOfAny(new char[] { '.', '-', '_', ',', '\'', '\"', ' ' }) >= 0)
                        continue;

                    datas.Add(sword);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox1.Text != "")
            {
                if (datas.Exists(str => str == textBox1.Text))
                {
                    datas.Remove(textBox1.Text);
                    rp.Add(textBox1.Text);
                    NextWord();
                    countDown += 3;
                    point++;
                    dingSound.Play();
                    lbl_Point.Text = point.ToString();
                }
                else if (rp.Exists(str => str == textBox1.Text))
                {
                    lives--;
                    lbl_Lives.Text = lives.ToString();
                    buzzSound.Play();
                    //Collapse();
                    //MessageBox.Show("Word already listed!!!");
                }    
                else
                {
                    lives--;
                    lbl_Lives.Text = lives.ToString();
                    buzzSound.Play();
                    //Collapse();
                    //MessageBox.Show("Word doesn't exits!!!");
                }

                if (lives == 0)
                {
                    Collapse();
                    buzzSound.Play();
                    Main.Instance.EnableForGame();
                    GameOver frm = new GameOver(rp, point);
                    frm.ShowDialog();
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Back && textBox1.Text.Length == 1)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.Handled = true;
            }
        }

        void NextWord()
        {
            Random random = new Random();

            if (textBox1.Text.Length == 0)
            {
                label1.Text = datas[random.Next(datas.Count)];
            }
            else
            {
                var temp = datas.FindAll(str => str.StartsWith(textBox1.Text.Last().ToString()));
                label1.Text = temp[random.Next(temp.Count)];
            }

            datas.Remove(label1.Text);
            textBox1.Text = label1.Text.Last().ToString();
            textBox1.SelectionStart = 1;
        }

        private void btn_HighScore_Click(object sender, EventArgs e)
        {
            HighScore frm = new HighScore();
            frm.ShowDialog();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            startTimer.Start();
            btn_Start.Visible = false;
            btn_HighScore.Visible = false;
            lbl_StartTime.Text = startTime.ToString();
            Main.Instance.DisableForGame();
        }

        void Collapse()
        {
            lbl_Point.Visible = false;
            lbl_P.Visible = false;
            lbl_Lives.Visible = false;
            lbl_L.Visible = false;

            btn_HighScore.Visible = true;
            btn_Start.Visible = true;
            textBox1.Text = "";
            textBox1.Visible = false;
            label1.Visible = false;
            lbl_CountDown.Visible = false;
            timer.Stop();
            tickingSound.Stop();
            countDown = 10;
            lbl_StartTime.Text = "";
        }

        void Review()
        {
            GetData();
            textBox1.Visible = true;
            label1.Visible = true;
            lbl_CountDown.Visible = true;
            lbl_CountDown.Text = countDown.ToString();
            textBox1.Focus();

            lbl_Point.Visible = true;
            lbl_P.Visible = true;
            lbl_Lives.Visible = true;
            lbl_L.Visible = true;
            point = 0;
            lives = 3;
            NextWord();
            timer.Start();
            tickingSound.PlayLooping();
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            startTime--;
            lbl_StartTime.Text = startTime.ToString();
            if (startTime == 0)
            {
                lbl_StartTime.Text = "GO!";
            }
            if (startTime == -1)
            {
                lbl_StartTime.Text = "";
                startTimer.Stop();
                startTime = 3;
                Review();
            }    
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            countDown--;
            lbl_CountDown.Text = countDown.ToString();
            tickingSound.PlayLooping();
            if (countDown < 0)
            {
                Collapse();
                buzzSound.Play();
                Main.Instance.EnableForGame();
                GameOver frm = new GameOver(rp, point);
                frm.ShowDialog();
            }
        }

        public void UpdateButton()
        {
            btn_Start.BackColor = this.BackColor;
            btn_HighScore.BackColor = this.BackColor;
        }
    }
}
