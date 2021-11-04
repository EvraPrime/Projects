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
    public partial class Order : Form
    {
        string Language;
        List<Discount> Discounts;
        int ID;
        private static Order instance;

        public Order()
        {
            InitializeComponent();
        }

        public Order(int id, string total,  string address, string date, string status, Color theme, string language, string discount)
        {
            InitializeComponent();
            Language = language;
            topPanel.BackColor = theme;
            btn_Close.BackColor = theme;

            ID = id;
            lbl_Name.Text = Main.GetMain().UserName;
            lbl_Phone.Text = Main.GetMain().Phone;
            lbl_Address.Text = address;

            cmb_Discount.Text = discount;
            lbl_Sum.Text = total;

            Discounts = new List<Discount>();

            instance = this;
        }

        public static Order GetOrder()
        {
            return instance;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            var con = DAL.GetDBConnection();
            con.Open();

            var sql = "SELECT * FROM Discount";
            var cmd = new MySqlCommand(sql, con);
            var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                cmb_Discount.Items.Add(rdr.GetString(0));
                Discounts.Add(new Discount(rdr.GetString(0), rdr.GetString(1), rdr.GetFloat(2), rdr.GetDateTime(3), rdr.GetDateTime(4), topPanel.BackColor, Language));
            }

            rdr.Close();

            sql = "SELECT `A`.`Amount`, `B`.`ID`, `B`.`Name`, `B`.`Price` " +
                  "FROM OrderDetail `A`" +
                  "INNER JOIN Item `B` ON `A`.`ItemID` = `B`.`ID`" +
                  " WHERE `A`.`BillID` = " + ID.ToString();
            cmd = new MySqlCommand(sql, con);
            rdr = cmd.ExecuteReader();
            Selected temp;
            while (rdr.Read())
            {
                temp = new Selected(Image.FromFile("Images/" + rdr.GetInt16(1).ToString() + ".jpg"), rdr.GetInt16(1), rdr.GetString(2),
                   rdr.GetDecimal(3).ToString(), rdr.GetInt32(0), topPanel.BackColor, Language);
                selectedItems.Controls.Add(temp);
            }

            con.Close();
            Refresh();
        }

        private decimal GetTotal()
        {
            decimal result = 0;

            foreach (Selected item in selectedItems.Controls)
            {
                result += decimal.Parse(item.Price) * item.Amount;
            }

            return result;
        }

        public override void Refresh()
        {
            base.Refresh();
            if (cmb_Discount.Text == "")
            {
                lbl_Discount.Text = "N/a";
                lbl_Sum.Text = (GetTotal() + decimal.Parse(lbl_Ship.Text)).ToString();
                return;
            }

            foreach (var x in Discounts)
            {
                if (cmb_Discount.Text == x.Code)
                {
                    lbl_Sum.Text = ((GetTotal() + decimal.Parse(lbl_Ship.Text)) * (1 - (decimal)x.Percent)).ToString();
                    lbl_Discount.Text = x.DiscountName;
                    return;
                }
            }

            lbl_Discount.Text = "N/a";
        }

        public void ChangeAmount(Selected item, int amount)
        {
            foreach (Selected selected in selectedItems.Controls)
            {
                if (selected.ItemName == item.ItemName)
                {
                    selected.UpdateAmount(amount);
                    return;
                }
            }
        }

        public void RemoveFromCart(Selected item)
        {
            selectedItems.Controls.Remove(item);
        }

        private void cmb_Discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
