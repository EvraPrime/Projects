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
    public partial class GameOver : Form
    {
        MySqlConnection con;

        public GameOver()
        {
            InitializeComponent();
        }

        public GameOver(List<string> data, int point)
        {
            InitializeComponent();
            lbl_Point.Text = point.ToString();
            listBox.Items.AddRange(data.ToArray());
            con = DAL.DBUtils.GetDBConnection();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

            try
            {
                con.Open();
                string name = txt_Name.Text == "" ? "Noname" : txt_Name.Text;
                string s = "Insert into highscore (name,point) values('" + name + "'," + lbl_Point.Text + ") ";
                MySqlCommand cmd = new MySqlCommand(s, con);
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

        private void GameOver_Load(object sender, EventArgs e)
        {
            this.BackColor = Main.Instance.ThemeColor;
            btn_Close.BackColor = Main.Instance.ThemeColor;
        }
    }
}
