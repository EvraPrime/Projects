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

namespace OnlineShop
{
    public partial class Statis : UserControl
    {
        string Language;
        public Statis()
        {
            InitializeComponent();
        }

        public void UpdateView(Color theme, string language)
        {
            topPanel.BackColor = theme;
            Language = language;
            if (language == "eg")
            {
                lbl_Title.Text = "Statis";
                lbl_D.Text = "Day";
                lbl_M.Text = "Month";
                lbl_Y.Text = "Year";
            }    
            else
            {
                lbl_Title.Text = "Thống kê";
                lbl_D.Text = "Ngày";
                lbl_M.Text = "Tháng";
                lbl_Y.Text = "Năm";
            }    
        }

        private void Statis_Load(object sender, EventArgs e)
        {
            var con = DAL.GetDBConnection();
            con.Open();

            string sql = "SELECT COUNT(ID)" + " FROM Bill" + " WHERE YEAR(`Date`) = YEAR(CURDATE())"  + " GROUP BY YEAR(Date)";

            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
                lbl_Year.Text = rdr.GetInt32(0).ToString();
            else
                lbl_Year.Text = 0.ToString();

            rdr.Close();

            sql = "SELECT COUNT(ID)" + " FROM Bill" + " WHERE MONTH(`Date`) = MONTH(CURDATE())" + " GROUP BY MONTH(Date)";
            cmd = new MySqlCommand(sql, con);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
                lbl_Month.Text = rdr.GetInt32(0).ToString();
            else
                lbl_Month.Text = 0.ToString();
            rdr.Close();

            sql = "SELECT COUNT(ID)" + " FROM Bill" + " WHERE DAY(`Date`) = DAY(CURDATE())" + " GROUP BY DAY(Date)";
            cmd = new MySqlCommand(sql, con);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
                lbl_Day.Text = rdr.GetInt32(0).ToString();
            else
                lbl_Day.Text = 0.ToString();

            rdr.Close();

            con.Close();
        }

        public override void Refresh()
        {
            base.Refresh();
            string str1, str2;
            if (Language == "eg")
            {
                str1 = "orders";
                str2 = "Total: ";
            }
            else
            {
                str1 = "đơn";
                str2 = "Tổng: ";
            }

            var con = DAL.GetDBConnection();
            con.Open();

            string sql = "SELECT COUNT(ID), SUM(Total)" + " FROM Bill" + " WHERE YEAR(`Date`) = YEAR(CURDATE())" + " GROUP BY YEAR(Date)";

            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                lbl_MonYear.Text = str2 + rdr.GetInt32(1).ToString();
                lbl_Year.Text = rdr.GetInt32(0).ToString() + " " + str1;
            }
            else
            {
                lbl_MonYear.Text = str2 + 0.ToString();
                lbl_Year.Text = 0.ToString() + " " + str1;
            }

            rdr.Close();

            sql = "SELECT COUNT(ID), SUM(Total)" + " FROM Bill" + " WHERE MONTH(`Date`) = MONTH(CURDATE())" + " GROUP BY MONTH(Date)";
            cmd = new MySqlCommand(sql, con);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                lbl_MonMonth.Text = str2 + rdr.GetInt32(1).ToString();
                lbl_Month.Text = rdr.GetInt32(0).ToString() + " " + str1;
            }
            else
            {
                lbl_MonMonth.Text = str2 + 0.ToString();
                lbl_Month.Text = 0.ToString() + " " + str1;
            }
            rdr.Close();

            sql = "SELECT COUNT(ID), SUM(Total)" + " FROM Bill" + " WHERE DAY(`Date`) = DAY(CURDATE())" + " GROUP BY DAY(Date)";
            cmd = new MySqlCommand(sql, con);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                lbl_MonDay.Text = str2 + rdr.GetInt32(1).ToString();
                lbl_Day.Text = rdr.GetInt32(0).ToString() + " " + str1;
            }
            else
            {
                lbl_MonDay.Text = str2 + 0.ToString();
                lbl_Day.Text = 0.ToString() + " " + str1;
            }

            rdr.Close();

            con.Close();
        }
    }
}
