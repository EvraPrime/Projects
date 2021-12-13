using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Control
{
    public partial class SearchView : Form
    {
        MySqlConnection con;
        public SearchView()
        {
            InitializeComponent();
        }

        public SearchView(string word, Color color)
        {
            InitializeComponent();
            con = DAL.DBUtils.GetDBConnection();
            lbl_Word.Text = word;
            this.BackColor = color;
            btn_Exit.BackColor = color;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Favourite_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string s = "select * from favourite where word='" + lbl_Word.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(s, con);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    s = "Delete from favourite where word='" + myReader.GetString(0) + "' ";
                    myReader.Close();
                    cmd = new MySqlCommand(s, con);
                    cmd.ExecuteNonQuery();
                    pic_Favourite.BackColor = Color.Transparent;
                }
                else
                {
                    s = "Insert into favourite (word) values('" + lbl_Word.Text + "') ";
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

        private void SearchView_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string s = "select * from dictionary where word='" + lbl_Word.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(s, con);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    pan_Content.Controls.Clear();

                    Label lb = new Label();
                    lb.Font = new Font("Arial", 10, FontStyle.Italic);
                    lb.AutoSize = true;
                    lb.MaximumSize = new Size(pan_Content.Width, 0);
                    lb.Text = myReader.GetString("pronounc");
                    pan_Content.Controls.Add(lb);

                    var x = myReader.GetString("description");
                    var list = Regex.Split(myReader.GetString("description"), @"(?=\~+[-=*!])"); //.Split(new string[] { "-", "*", "=" }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < list.Length; i++)
                    {
                        Label label = new Label();
                        label.AutoSize = true;
                        label.MaximumSize = new Size(pan_Content.Width, 0);

                        if (list[i].Contains("~*"))
                        {
                            label.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
                            label.Text = Regex.Replace(list[i].Trim(), @"\A\~+\*", "\u2022");
                        }
                        else if (list[i].Contains("~!"))
                        {
                            label.Font = new Font("Arial", 10, FontStyle.Bold);
                            label.Text = Regex.Replace(list[i].Trim(), @"\A\~+\!", "        \u25E6");
                        }
                        else if (list[i].Contains("~-"))
                        {
                            label.Font = new Font("Arial", 10);
                            label.Text = Regex.Replace(list[i].Trim(), @"\A\~+\-", "              \u25A0 ");
                            label.ForeColor = Main.Instance.ThemeColor;
                        }
                        else
                        {
                            label.Font = new Font("Arial", 10);
                            string str = Regex.Replace(list[i].Trim(), @"\A\~+\=", "                      \u25A1 ");
                            label.Text = Regex.Replace(str, @"\+", ":");
                        }

                        pan_Content.Controls.Add(label);
                    }

                    myReader.Close();

                    s = "select * from favourite where word='" + lbl_Word.Text + "' ";
                    cmd = new MySqlCommand(s, con);
                    myReader = cmd.ExecuteReader();

                    if (myReader.Read())
                        pic_Favourite.BackColor = Main.Instance.ThemeColor;
                    else
                        pic_Favourite.BackColor = Color.Transparent;
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

        private void pic_Speak_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = 100;
            speechSynthesizer.Rate = 0;
            speechSynthesizer.SpeakAsync(lbl_Word.Text);
        }
    }
}
