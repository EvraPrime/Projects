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
    public partial class Settings : UserControl
    {
        MySqlConnection con;

        public Settings()
        {
            InitializeComponent();
            con = DAL.DBUtils.GetDBConnection();
        }

        private void pic_Click(object sender, EventArgs e)
        {
            Main.Instance.ChangeColor(((PictureBox)sender).BackColor);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn sẽ xóa toàn bộ lịch sử (bao gồm cả bảng xếp hạng) ?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string s = "Delete from history";
                    MySqlCommand cmd = new MySqlCommand(s, con);
                    cmd.ExecuteNonQuery();

                    s = "Delete from highscore";
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
}
