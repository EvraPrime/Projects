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
    public partial class History : UserControl
    {
        MySqlConnection con;
        public History()
        {
            InitializeComponent();
            con = DAL.DBUtils.GetDBConnection();
        }

        public void UpdateResult()
        {
            pan_Content.Controls.Clear();
            try
            {
                con.Open();
                string s = "select * from history";
                MySqlCommand cmd = new MySqlCommand(s, con);
                MySqlDataReader myReader = cmd.ExecuteReader();
                string word, form, to;
                List<HistoryItem> items = new List<HistoryItem>();

                while (myReader.Read())
                {
                    word = myReader.IsDBNull(1) ? "" : myReader.GetString(1);
                    form = myReader.IsDBNull(2) ? "" : myReader.GetString(2);
                    to = myReader.IsDBNull(3) ? "" : myReader.GetString(3);
                    items.Add(new HistoryItem(myReader.GetString(0), word, form, to, myReader.GetString(4), Main.Instance.ThemeColor));
                }

                items.Reverse();
                pan_Content.Controls.AddRange(items.ToArray());
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
