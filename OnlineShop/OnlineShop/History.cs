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
    public partial class History : UserControl
    {
        string Language;

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            var con = DAL.GetDBConnection();
            con.Open();

            string sql = "SELECT * FROM Bill WHERE Status = 'Ordering'";

            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();
            OrderItem temp;
            while (rdr.Read())
            {
                if (rdr.IsDBNull(4))
                    temp = new OrderItem(rdr.GetInt32(0), rdr.GetDecimal(1), rdr.GetString(2), rdr.GetDateTime(3), rdr.GetString(5));
                else
                    temp = new OrderItem(rdr.GetInt32(0), rdr.GetDecimal(1), rdr.GetString(2), rdr.GetDateTime(3), rdr.GetString(5), rdr.GetString(4));
                temp.UpdateView(topPanel.BackColor, Language); orderItems.Controls.Add(temp);
            }

            rdr.Close();
            rdr.Dispose();
            con.Close();
        }

        private void btn_Ordering_Click(object sender, EventArgs e)
        {
            orderItems.Controls.Clear();

            var con = DAL.GetDBConnection();
            con.Open();

            string sql = "SELECT * FROM Bill WHERE Status = 'Ordering'";

            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();
            OrderItem temp;
            while (rdr.Read())
            {
                if (rdr.IsDBNull(4))
                    temp = new OrderItem(rdr.GetInt32(0), rdr.GetDecimal(1), rdr.GetString(2), rdr.GetDateTime(3), rdr.GetString(5));
                else
                    temp = new OrderItem(rdr.GetInt32(0), rdr.GetDecimal(1), rdr.GetString(2), rdr.GetDateTime(3), rdr.GetString(5), rdr.GetString(4));
                temp.UpdateView(topPanel.BackColor, Language);
                orderItems.Controls.Add(temp);
            }

            rdr.Close();
            rdr.Dispose();
            con.Close();
        }

        private void btn_Delivery_Click(object sender, EventArgs e)
        {
            orderItems.Controls.Clear();

            var con = DAL.GetDBConnection();
            con.Open();

            string sql = "SELECT * FROM Bill WHERE Status = 'Shipping'";

            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();
            OrderItem temp;
            while (rdr.Read())
            {
                if (rdr.IsDBNull(4))
                    temp = new OrderItem(rdr.GetInt32(0), rdr.GetDecimal(1), rdr.GetString(2), rdr.GetDateTime(3), rdr.GetString(5));
                else
                    temp = new OrderItem(rdr.GetInt32(0), rdr.GetDecimal(1), rdr.GetString(2), rdr.GetDateTime(3), rdr.GetString(5), rdr.GetString(4));
                temp.UpdateView(topPanel.BackColor, Language);
                orderItems.Controls.Add(temp);
            }

            rdr.Close();
            rdr.Dispose();
            con.Close();
        }

        private void btn_Success_Click(object sender, EventArgs e)
        {
            orderItems.Controls.Clear();

            var con = DAL.GetDBConnection();
            con.Open();

            string sql = "SELECT * FROM Bill WHERE Status = 'Success'";

            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();
            OrderItem temp;

            while (rdr.Read())
            {
                if (rdr.IsDBNull(4))
                    temp = new OrderItem(rdr.GetInt32(0), rdr.GetDecimal(1), rdr.GetString(2), rdr.GetDateTime(3), rdr.GetString(5));
                else
                    temp = new OrderItem(rdr.GetInt32(0), rdr.GetDecimal(1), rdr.GetString(2), rdr.GetDateTime(3), rdr.GetString(5), rdr.GetString(4));
                temp.UpdateView(topPanel.BackColor, Language); orderItems.Controls.Add(temp);
            }

            rdr.Close();
            rdr.Dispose();
            con.Close();
        }

        public void UpdateView(Color theme, string language)
        {
            topPanel.BackColor = theme;
            Language = language;
            foreach(OrderItem item in orderItems.Controls)
            {
                item.UpdateView(theme, language);
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            orderItems.Controls.Clear();
            var con = DAL.GetDBConnection();
            con.Open();

            string sql = "SELECT * FROM Bill WHERE Status = 'Ordering'";

            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();
            OrderItem temp;
            while (rdr.Read())
            {
                if (rdr.IsDBNull(4))
                    temp = new OrderItem(rdr.GetInt32(0), rdr.GetDecimal(1), rdr.GetString(2), rdr.GetDateTime(3), rdr.GetString(5));
                else
                    temp = new OrderItem(rdr.GetInt32(0), rdr.GetDecimal(1), rdr.GetString(2), rdr.GetDateTime(3), rdr.GetString(5), rdr.GetString(4));
                temp.UpdateView(topPanel.BackColor, Language); 
                orderItems.Controls.Add(temp);
            }

            rdr.Close();
            rdr.Dispose();
            con.Close();
        }
    }
}
