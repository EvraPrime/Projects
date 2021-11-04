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
        string Status;

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

            if (language == "eg")
            {
                lbl_Title.Text = "Order";
                lbl_A.Text = "Address:";
                lbl_N.Text = "Name:";
                lbl_P.Text = "Phone Number:";
                lbl_F.Text = "Shipping Fee";
                lbl_T.Text = "Total";
                btn_Pay.Text = "Order";
                if (isChanging)
                    lbl_Change.Text = "Save";
                else
                    lbl_Change.Text = "Change";
            }   
            else
            {
                lbl_Title.Text = "Đơn hàng";
                lbl_A.Text = "Địa chỉ:";
                lbl_N.Text = "Tên:";
                lbl_P.Text = "Số điện thoại:";
                lbl_F.Text = "Phí vận chuyển";
                lbl_T.Text = "Thành tiền";
                btn_Pay.Text = "Đặt hàng";
                if (isChanging)
                    lbl_Change.Text = "Lưu";
                else
                    lbl_Change.Text = "Thay đổi";
            }    

            Discounts = new List<Discount>();
            Status = status;
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
            if (Status == "Shipping")
            {
                selectedItems.Enabled = false;
                cmb_Discount.Enabled = false;
            }

            if (Status == "Success")
            {
                selectedItems.Enabled = false;
                cmb_Discount.Enabled = false;
                btn_Pay.Visible = false;
                btn_Cancel.Visible = false;
                lbl_Change.Visible = false;
            }

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

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (cmb_Discount.Text != "")
            {
                bool inValid = true;
                foreach (var temp in Discounts)
                {
                    if (cmb_Discount.Text == temp.Code)
                    {
                        inValid = false;
                        break;
                    }
                }
                if (inValid)
                {
                    MessageBox.Show("Invalid discount code!!!");
                    return;
                }
            }

            if (isChanging)
            {
                MessageBox.Show("Please finsih your change!!!");
                return;
            }

            var x = Main.GetMain();
            string str = "Cart doesn't have any item!!!";
            string s = "Oders success!!!";

            if (selectedItems.Controls.Count == 0)
            {
                MessageBox.Show(str);
            }
            else
            {
                var con = DAL.GetDBConnection();
                con.Open();
                string sqlOrder = "DELETE FROM OrderDetail "
                                + "WHERE `BillID` = " + ID.ToString();

                try
                {
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = sqlOrder;
                    cmd.ExecuteNonQuery();

                    if (cmb_Discount.Text == "")
                    {
                        sqlOrder = "UPDATE Bill SET Address = '" + lbl_Address.Text + "', Total = " + lbl_Sum.Text +
                                    " WHERE ID = " + ID.ToString();
                    }
                    else
                    {
                        sqlOrder = "UPDATE Bill SET Address = '" + lbl_Address.Text + "', Total = " + lbl_Sum.Text + ", Discount = '" + cmb_Discount.Text +
                                    "' WHERE ID = " + ID.ToString();
                    }

                    cmd = con.CreateCommand();
                    cmd.CommandText = sqlOrder;
                    cmd.ExecuteNonQuery();

                    StringBuilder sql = new StringBuilder();
                    sql.Append("INSERT INTO OrderDetail (BillID, ItemID, Amount) VALUES");

                    foreach (Selected selected in selectedItems.Controls)
                    {
                        sql.AppendFormat("({0}, {1}, {2}) ,", ID, selected.ID, selected.Amount);
                    }
                    sql.Remove(sql.Length - 1, 1);
                    string sqlCommand = sql.ToString();
                    cmd.CommandText = sqlCommand;
                    cmd.ExecuteNonQuery();

                    Main.GetMain().Refresh();

                    MessageBox.Show("Change success!!!");
                    this.Close();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error: " + er + '\n' + er.StackTrace);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Alert!!!", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var con = DAL.GetDBConnection();
            con.Open();
            string sqlOrder = "DELETE FROM OrderDetail "
                            + "WHERE `BillID` = " + ID.ToString();

            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlOrder;

                cmd.ExecuteNonQuery();

                sqlOrder = "DELETE FROM Bill " +
                           "WHERE `ID` = " + ID.ToString();

                cmd.CommandText = sqlOrder;
                cmd.ExecuteNonQuery();

                Main.GetMain().Refresh();

                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er + '\n' + er.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }

        bool isChanging = false;

        private void lbl_Change_Click(object sender, EventArgs e)
        {
            isChanging = !isChanging;

            if (isChanging)
            {
                txt_Address.Text = lbl_Address.Text;
                txt_Address.Visible = true;
                lbl_Address.Visible = false;
                if (Language == "eg")
                    lbl_Change.Text = "Save";
                else
                    lbl_Change.Text = "Lưu";
            }
            else
            {
                txt_Address.Visible = false;
                lbl_Address.Visible = true;

                Main.GetMain().Address = lbl_Address.Text = txt_Address.Text;

                if (Language == "eg")
                    lbl_Change.Text = "Change";
                else
                    lbl_Change.Text = "Thay đổi";
            }
        }
    }
}
