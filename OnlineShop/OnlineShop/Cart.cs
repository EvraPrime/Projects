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
    public partial class Cart : Form
    {
        string Language;
        List<Discount> Discounts;

        public Cart()
        {
            InitializeComponent();
        }

        public Cart(Selected[] selecteds, List<Discount> discounts, Color theme, string language)
        {
            InitializeComponent();
            Discounts = new List<Discount>();
            Discounts = discounts;
            topPanel.BackColor = theme;
            btn_Close.BackColor = theme;
            selectedItems.Controls.AddRange(selecteds);
            Language = language;

            if (language == "eg")
            {
                lbl_Title.Text = "Cart";
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
                lbl_Title.Text = "Giỏ hàng";
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

            foreach (Discount discount in discounts)
            {
                cmb_Discount.Items.Add(discount.Code);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            lbl_Name.Text = Main.GetMain().UserName;
            lbl_Phone.Text = Main.GetMain().Phone;
            lbl_Address.Text = Main.GetMain().Address;
            lbl_Sum.Text = (Main.GetMain().GetTotal() + decimal.Parse(lbl_Ship.Text)).ToString();
        }

        public override void Refresh()
        {
            base.Refresh();
            if (cmb_Discount.Text == "")
            {
                lbl_Discount.Text = "N/a";
                lbl_Sum.Text = (Main.GetMain().GetTotal() + decimal.Parse(lbl_Ship.Text)).ToString();
                return;
            }

            foreach (var x in Discounts)
            {
                if (cmb_Discount.Text == x.Code)
                {
                    lbl_Sum.Text = ((Main.GetMain().GetTotal() + decimal.Parse(lbl_Ship.Text)) * (1 - (decimal)x.Percent)).ToString();
                    lbl_Discount.Text = x.DiscountName;
                    return;
                }
            }

            lbl_Discount.Text = "N/a";
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
                    if (Language == "eg")
                        MessageBox.Show("Invalid discount code!!!");
                    else
                        MessageBox.Show("Mã khuyến mãi không hợp lệ!!!");
                    return;
                }
            }

            if (isChanging)
            {
                if (Language == "eg")
                    MessageBox.Show("Please finsih your change!!!");
                else
                    MessageBox.Show("Xin lưu lại những gì đã thay đổi!!!");
                return;
            }

            var x = Main.GetMain();
            string str = "Cart doesn't have any item!!!";
            string s = "Oders success!!!";

            if (Language == "eg")
            {
                str = "Cart doesn't have any item!!!";
                s = "Oders success!!!";
            }   
            else
            {
                str = "Giỏ hàng không có vật phẩm!!!";
                s = "Đặt hàng thành công!!!";
            }    

            if (x.GetCart().Count == 0)
            {
                MessageBox.Show(str);
            }
            else
            {
                var con = DAL.GetDBConnection();
                con.Open();
                string sqlBill = "INSERT INTO Bill (Total, Address, Date, Discount, Status) "
                               + "VALUES (@Total, @Address, @Date, @Discount, @Status)";

                StringBuilder sqlOrder = new StringBuilder();
                sqlOrder.Append("INSERT INTO OrderDetail (BillID, ItemID, Amount) VALUES");

                try
                {
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = sqlBill;

                    cmd.Parameters.Add("@Total", MySqlDbType.Decimal).Value = decimal.Parse(lbl_Sum.Text);
                    cmd.Parameters.Add("@Address", MySqlDbType.VarChar).Value = lbl_Address.Text;
                    cmd.Parameters.Add("@Date", MySqlDbType.Date).Value = DateTime.Now;

                    if (cmb_Discount.Text != "")
                        cmd.Parameters.Add("@Discount", MySqlDbType.VarChar).Value = cmb_Discount.Text;
                    else
                        cmd.Parameters.Add("@Discount", MySqlDbType.VarChar).Value = null;

                    cmd.Parameters.Add("@Status", MySqlDbType.VarChar).Value = "Ordering";

                    cmd.ExecuteNonQuery();
                    ///////
                    string sql = "SELECT * FROM Bill ORDER BY ID DESC LIMIT 1";

                    cmd = new MySqlCommand(sql, con);

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    int temp;
                    rdr.Read();
                    temp = rdr.GetInt32(0);
                    rdr.Close();
                    rdr.Dispose();
                    ///////
                    cmd = con.CreateCommand();
                    foreach (Selected selected in x.GetCart())
                    {
                        sqlOrder.AppendFormat("({0}, {1}, {2}) ,", temp, selected.ID, selected.Amount);
                    }
                    sqlOrder.Remove(sqlOrder.Length - 1, 1);
                    string sqlCommand = sqlOrder.ToString();
                    cmd.CommandText = sqlCommand;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(s);
                    x.GetCart().Clear();

                    
                    this.Close();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error: " + er  + '\n' + er.StackTrace);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void cmb_Discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Discount.Text == "")
            {
                lbl_Discount.Text = "N/a";
                lbl_Sum.Text = (Main.GetMain().GetTotal() + decimal.Parse(lbl_Ship.Text)).ToString();
                return;
            }

            foreach (var x in Discounts)
            {
                if (cmb_Discount.Text == x.Code)
                {
                    lbl_Sum.Text = ((Main.GetMain().GetTotal() + decimal.Parse(lbl_Ship.Text)) * (1 - (decimal)x.Percent)).ToString();
                    lbl_Discount.Text = x.DiscountName;
                    return;
                }
            }

            lbl_Discount.Text = "N/a";
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
