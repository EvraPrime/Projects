using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Control
{
    public partial class TranslateView : Form
    {
        MySqlConnection con;
        public TranslateView()
        {
            InitializeComponent();
        }

        public TranslateView(string from, string to, Color color)
        {
            InitializeComponent();
            rtbFrom.Text = from;
            rtbTo.Text = to;
            this.BackColor = color;
            btn_Exit.BackColor = color;
            con = DAL.DBUtils.GetDBConnection();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Speak_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = 100;
            speechSynthesizer.Rate = 0;
            speechSynthesizer.SpeakAsync(rtbTo.Text);
        }

        private void pic_Favourite_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string s = "select * from translate where fromvi='" + rtbFrom.Text.Trim() + "' ";
                MySqlCommand cmd = new MySqlCommand(s, con);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    s = "Delete from translate where fromvi='" + myReader.GetString(0) + "' ";
                    myReader.Close();
                    cmd = new MySqlCommand(s, con);
                    cmd.ExecuteNonQuery();
                    pic_Favourite.BackColor = Color.Gray;
                }
                else
                {
                    s = "Insert into translate (fromvi,toen) values('" + rtbFrom.Text.Trim() + "','" + rtbTo.Text.Trim() + "') ";
                    myReader.Close();
                    cmd = new MySqlCommand(s, con);
                    cmd.ExecuteNonQuery();
                    pic_Favourite.BackColor = Main.Instance.ThemeColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void TranslateView_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string s = "select * from translate where fromvi='" + rtbFrom.Text.Trim() + "' ";
                MySqlCommand cmd = new MySqlCommand(s, con);
                MySqlDataReader myReader = cmd.ExecuteReader();

                if (myReader.Read())
                    pic_Favourite.BackColor = Main.Instance.ThemeColor;
                else
                    pic_Favourite.BackColor = Color.Gray;

                s = "Insert into history (action,fromvi,toen,date) values('Translate','" + rtbFrom.Text.Trim() + "','" + rtbTo.Text.Trim() + "','" + DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "') ";
                myReader.Close();
                cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
