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
    public partial class Favourite : UserControl
    {
        MySqlConnection con;
        public Favourite()
        {
            InitializeComponent();
            con = DAL.DBUtils.GetDBConnection();
        }
        
        public void UpdateResult()
        {
            pan_Search.BringToFront();
            pan_Search.Controls.Clear();
            pan_Translate.Controls.Clear();
            try
            {
                con.Open();
                string s = "select * from favourite";
                MySqlCommand cmd = new MySqlCommand(s, con);
                MySqlDataReader myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    pan_Search.Controls.Add(new SearchResult(myReader.GetString(0), Main.Instance.ThemeColor));
                }

                myReader.Close();
                s = "select * from translate";
                cmd = new MySqlCommand(s, con);
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    pan_Translate.Controls.Add(new TranslateResult(myReader.GetString(0), myReader.GetString(1), Main.Instance.ThemeColor));
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            pan_Search.BringToFront();
        }

        private void btn_Translate_Click(object sender, EventArgs e)
        {
            pan_Translate.BringToFront();
        }
    }
}
