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
        public Game()
        {
            InitializeComponent();
            con = DBUtils.GetDBConnection();
            datas = new List<string>();
            GetData();
        }

        void GetData()
        {
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

                }
                else
                {
                    MessageBox.Show("Word doesn't exits!!!");
                }    
            }    
        }
    }
}
