using Dictionary.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        bool isRandom = true;
        public Game()
        {
            InitializeComponent();
            con = DBUtils.GetDBConnection();
            datas = new List<string>();
            rp = new List<string>();
            GetData();
            NextWord();
        }

        void GetData()
        {
            datas.Clear();
            rp.Clear();
            string query = "select * from tbl_edict";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sword = myReader.GetString("word");
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
                    MessageBox.Show("Word already listed!!!");
                }    
                else
                {
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
        }

        void NextWord()
        {
            if (isRandom)
            {
                isRandom = false;
                Random random = new Random();
                textBox1.Text = datas[random.Next(0, datas.Count)];
            }    
            label1.Text = datas.Find(str => str.StartsWith(textBox1.Text.Last().ToString()));
            datas.Remove(label1.Text);
            textBox1.Text = label1.Text.Last().ToString();
        }
    }
}
