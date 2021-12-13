using Dictionary.Control;
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
    public partial class HighScore : Form
    {
        MySqlConnection con;

        public HighScore()
        {
            InitializeComponent();
            con = DAL.DBUtils.GetDBConnection();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            this.BackColor = Main.Instance.ThemeColor;
            pan_Scores.Controls.Clear();
            try
            {
                con.Open();
                string s = "select * from highscore order by point desc";
                MySqlCommand cmd = new MySqlCommand(s, con);
                MySqlDataReader myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    pan_Scores.Controls.Add(new PlayerItem(myReader.GetString(0), myReader.GetInt32(1)));
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
    }
}
