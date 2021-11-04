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
    public partial class OrderItem : UserControl
    {
        int ID;
        string Status;
        string Language;
        string Discount;

        public OrderItem()
        {
            InitializeComponent();
        }

        public OrderItem(int id, decimal total, string address, DateTime date, string status, string discount = null)
        {
            InitializeComponent();
            ID = id;
            lbl_Total.Text = total.ToString();
            lbl_Address.Text = address;
            lbl_Date.Text = date.ToShortDateString();
            Status = status;
            Discount = discount;
        }

        private void OrderItem_Click(object sender, EventArgs e)
        {
            Order form = new Order(ID, lbl_Total.Text, lbl_Address.Text, lbl_Date.Text, Status, BackColor, Language, Discount);
            form.ShowDialog();
        }

        private void OrderItem_Load(object sender, EventArgs e)
        {
            switch (Status)
            {
                case "Ordering":
                    pic_Order.Image = Image.FromFile("Images/package.png");
                    break;
                case "Shipping":
                    pic_Order.Image = Image.FromFile("Images/delivery.png");
                    break;
                case "Success":
                    pic_Order.Image = Image.FromFile("Images/check.png");
                    break;
                default:
                    pic_Order.Image = Image.FromFile("Images/default.jpg");
                    break;
            }

            var con = DAL.GetDBConnection();
            con.Open();

            var sql = "SELECT `A`.`Amount`, `B`.`Name`" +
                  "FROM OrderDetail `A`" +
                  "INNER JOIN Item `B` ON `A`.`ItemID` = `B`.`ID`" +
                  " WHERE `A`.`BillID` = " + ID.ToString();
            var cmd = new MySqlCommand(sql, con);
            var rdr = cmd.ExecuteReader();

            string f = "";
            while (rdr.Read())
            {
                f += rdr.GetString(1) + " x" + rdr.GetInt32(0).ToString() + " ";
            }

            lbl_ID.Text = f;

            con.Close();
            Refresh();
        }

        public void UpdateView(Color theme, string language)
        {
            BackColor = theme;
            Language = language;
        }
    }
}
