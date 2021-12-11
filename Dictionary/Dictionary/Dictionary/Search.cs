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
        public Search()
        {
            InitializeComponent();
            con = DBUtils.GetDBConnection();
            AutoCompleteText();
        }

        void AutoCompleteText()
        {
            Search_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Search_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            Search_txt.AutoCompleteCustomSource = col;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string s = "select * from dictionary where word='" + this.Search_txt.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(s, con);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    panel1.Controls.Clear();

                    Label lb = new Label();
                    lb.Font = new Font("Arial", 10);
                    lb.AutoSize = true;
                    lb.MaximumSize = new Size(panel1.Width, 0);
                    lb.Text = myReader.GetString("pronounc");
                    panel1.Controls.Add(lb);

                    var list = Regex.Split(myReader.GetString("description"), @"(?=[-+=])"); //.Split(new string[] { "-", "+", "=" }, StringSplitOptions.RemoveEmptyEntries);
                    
                    for (int i = 0; i < list.Length; i++)
                    {
                        Label label = new Label();
                        label.Font = new Font("Arial", 10);
                        label.AutoSize = true;
                        label.MaximumSize = new Size(panel1.Width, 0);
                        label.Text = list[i].Trim();
                        panel1.Controls.Add(label);
                    }    
                }
                else
                {
                    panel1.Controls.Clear();
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
                button1.PerformClick();
            }    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = 100;
            speechSynthesizer.Rate = 0;
            speechSynthesizer.SpeakAsync(Search_txt.Text);
        }
    }
}
