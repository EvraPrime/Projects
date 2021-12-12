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
        int countDown = 10;
        SoundPlayer tickingSound, alarmSound;

        public Game()
        {
            InitializeComponent();
            con = DBUtils.GetDBConnection();
            datas = new List<string>();
            rp = new List<string>();
            tickingSound = new SoundPlayer("ticking.wav");
            alarmSound = new SoundPlayer("alarm.wav");
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
                }
                else if (rp.Exists(str => str == textBox1.Text))
                {
                    Collapse();
                    MessageBox.Show("Word already listed!!!");
                }    
                else
                {
                    Collapse();
                    MessageBox.Show("Word doesn't exits!!!");
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
            countDown = 11;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Review();
        }

        void Collapse()
        {
            btn_Start.Visible = true;
            textBox1.Text = "";
            textBox1.Visible = false;
            label1.Visible = false;
            lbl_CountDown.Visible = false;
            timer.Stop();
            tickingSound.Stop();
            countDown = 10;
        }

        void Review()
        {
            GetData();
            btn_Start.Visible = false;
            textBox1.Visible = true;
            label1.Visible = true;
            lbl_CountDown.Visible = true;
            textBox1.Focus();
            timer.Start();
            tickingSound.PlayLooping();
            NextWord();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            countDown--;
            if (countDown < 0)
            {
                Collapse();
                alarmSound.Play();
                var result = MessageBox.Show("Out of time!!!");
                if (result == DialogResult.OK)
                {
                    alarmSound.Stop();
                }
            }

            lbl_CountDown.Text = countDown.ToString();
        }
    }
}
