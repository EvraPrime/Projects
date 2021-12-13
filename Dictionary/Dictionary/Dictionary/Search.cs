using Dictionary.DAL;
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

namespace Dictionary
{
    public partial class Search : UserControl
    {
        MySqlConnection con;
        bool isFail = false;

        public Search()
        {
            InitializeComponent();
            con = DBUtils.GetDBConnection();
            AutoCompleteText();
            pic_Favourite.Visible = false;
        }

        void AutoCompleteText()
        {
            txt_Search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_Search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

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
                    col.Add(sword);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
            txt_Search.AutoCompleteCustomSource = col;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string s = "select * from dictionary where word='" + txt_Search.Text + "' ";
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

                    isFail = false;
                    pic_Favourite.Visible = true;
                    s = "select * from favourite where word='" + txt_Search.Text + "' ";
                    cmd = new MySqlCommand(s, con);
                    myReader = cmd.ExecuteReader();

                    if (myReader.Read())
                        pic_Favourite.BackColor = Main.Instance.ThemeColor;
                    else
                        pic_Favourite.BackColor = Color.Transparent;

                    s = "Insert into history (action,word,date) values('Search','" + txt_Search.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "') ";
                    myReader.Close();
                    cmd = new MySqlCommand(s, con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    pan_Content.Controls.Clear();
                    Label label = new Label();
                    label.AutoSize = true;
                    label.MaximumSize = new Size(pan_Content.Width, 0);
                    label.Font = new Font("Arial", 10);

                    if (txt_Search.Text == "")
                    {
                        label.Text = "Ô tìm kiếm trống!";
                    }
                    else
                    {
                        label.Text = "Không tìm thấy từ \"" + txt_Search.Text + "\" trong từ điển!";
                    }

                    isFail = true;
                    pic_Favourite.Visible = false;
                    pan_Content.Controls.Add(label);
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

        private void Search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Search.PerformClick();
            }    
        }

        private void pic_Speak_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
                return;

            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = 100;
            speechSynthesizer.Rate = 0;
            speechSynthesizer.SpeakAsync(txt_Search.Text);
        }

        private void pic_Favourite_Click(object sender, EventArgs e)
        {
            if (isFail)
                return;

            try
            {
                con.Open();
                string s = "select * from favourite where word='" + txt_Search.Text + "' ";
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
                    s = "Insert into favourite (word) values('" + txt_Search.Text + "') ";
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

        public void Clear()
        {
            txt_Search.Text = "";
            btn_Search.PerformClick();
        }
    }
}
