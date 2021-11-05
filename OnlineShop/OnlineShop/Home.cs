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
    public partial class Home : UserControl
    {
        List<Item> items;
        List<Item> apples;
        List<Discount> discounts;
        string Language;

        public Home()
        {
            InitializeComponent();
            items = new List<Item>();
            apples = new List<Item>();
            discounts = new List<Discount>();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            newItems.Controls.Clear();
            appleItems.Controls.Clear();

            List<Item> list = items.OrderBy(x => x.Date).ToList();
            list.Reverse();

            int count = 0;
            foreach (Item item in list)
            {
                newItems.Controls.Add(item);
                count++;
                if (count == 5)
                    break;
            }
            count = 0;
            list = new List<Item>();
            list = apples.OrderBy(x => x.Date).ToList();
            list.Reverse();
            foreach (Item item in list)
            {
                appleItems.Controls.Add(item);
                count++;
                if (count == 5)
                    break;
            }

            pan_Item.BringToFront();
        }

        private void btn_Discount_Click(object sender, EventArgs e)
        {
            pan_Discount.BringToFront();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            pic_Back_Click(sender, e);
            pan_Search.BringToFront();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Language = "eg";
            var con = DAL.GetDBConnection();
            con.Open();

            string sql = "SELECT * FROM Item";
            
            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();
            Item temp;
            while (rdr.Read())
            {
                temp = new Item(rdr.GetInt32(0), rdr.GetString(1), rdr.GetDecimal(2), rdr.GetString(3), rdr.GetDateTime(4), topPanel.BackColor, Language);
                items.Add(temp);
                if (temp.Type == "Apple")
                    apples.Add(new Item(rdr.GetInt32(0), rdr.GetString(1), rdr.GetDecimal(2), rdr.GetString(3), rdr.GetDateTime(4), topPanel.BackColor, Language));

                searchBox.Items.Add(rdr.GetString(1));
            }

            rdr.Close();

            sql = "SELECT * FROM Discount";
            cmd = new MySqlCommand(sql, con);
            rdr = cmd.ExecuteReader();
            Discount discount;
            while (rdr.Read())
            {
                discount = new Discount(rdr.GetString(0), rdr.GetString(1), rdr.GetFloat(2), rdr.GetDateTime(3), rdr.GetDateTime(4), topPanel.BackColor, Language);
                discounts.Add(discount);
                pan_Discount.Controls.Add(discount);
            }

            rdr.Close();
            con.Close();

            List<Item> list = items.OrderBy(x => x.Date).ToList();
            list.Reverse();
            int count = 0;
            foreach (Item item in list)
            {
                newItems.Controls.Add(item);
                count++;
                if (count == 5)
                    break;
            }
            count = 0;
            list = new List<Item>();
            list = apples.OrderBy(x => x.Date).ToList();
            list.Reverse();
            foreach (Item item in list)
            {
                appleItems.Controls.Add(item);
                count++;
                if (count == 5)
                    break;
            }
        }

        private void pic_Search_Click(object sender, EventArgs e)
        {
            searchItems.Controls.Clear();
            foreach (Item item in items)
            {
                if (item.ItemName.Contains(searchBox.Text))
                {
                    item.UpdateView(topPanel.BackColor, Language);
                    searchItems.Controls.Add(item);
                }
            }
            ChangeUI();
        }

        private void btn_Laptop_Click(object sender, EventArgs e)
        {
            searchItems.Controls.Clear();
            foreach (Item item in items)
            {
                if (item.Type == "Laptop")
                {
                    item.UpdateView(topPanel.BackColor, Language);
                    searchItems.Controls.Add(item);
                }
            }
            ChangeUI();
        }

        private void btn_Android_Click(object sender, EventArgs e)
        {
            searchItems.Controls.Clear();
            foreach (Item item in items)
            {
                if (item.Type == "Android")
                {
                    item.UpdateView(topPanel.BackColor, Language);
                    searchItems.Controls.Add(item);
                }
            }
            ChangeUI();
        }

        private void btn_Apple_Click(object sender, EventArgs e)
        {
            searchItems.Controls.Clear();
            foreach (Item item in items)
            {
                if (item.Type == "Apple")
                {
                    item.UpdateView(topPanel.BackColor, Language);
                    searchItems.Controls.Add(item);
                }
            }
            ChangeUI();
        }

        private void btn_TV_Click(object sender, EventArgs e)
        {
            searchItems.Controls.Clear();
            foreach (Item item in items)
            {
                if (item.Type == "TV")
                {
                    item.UpdateView(topPanel.BackColor, Language);
                    searchItems.Controls.Add(item);
                }
            }
            ChangeUI();
        }

        private void ChangeUI()
        {
            foreach (Item item in searchItems.Controls)
            {
                item.UpdateView(topPanel.BackColor, Language);
            }

            pic_Back.Visible = true;
            btn_Android.Visible = false;
            btn_Laptop.Visible = false;
            btn_Apple.Visible = false;
            btn_TV.Visible = false;
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            pic_Back.Visible = false;
            btn_Android.Visible = true;
            btn_Laptop.Visible = true;
            btn_Apple.Visible = true;
            btn_TV.Visible = true;
            searchItems.Controls.Clear();
        }

        private void pic_Cart_Click(object sender, EventArgs e)
        {
            var x = Main.GetMain().GetCart().ToArray();
            string str;

            if (Language == "eg")
                str = "Cart doesn't have any item!!!";
            else
                str = "Giỏ hàng không có sản phẩm!!!";

            if (x.Length == 0)
                MessageBox.Show(str);
            else
            {
                Cart form = new Cart(x, discounts, topPanel.BackColor, Language);
                form.ShowDialog();
            }
        }

        public void UpdateView(Color theme, string language)
        {
            topPanel.BackColor = theme;
            btn_Android.BackColor = theme;
            btn_Apple.BackColor = theme;
            btn_Laptop.BackColor = theme;
            btn_TV.BackColor = theme;

            Language = language;

            if (language == "eg")
            {
                btn_Item.Text = "Items";
                btn_Discount.Text = "Discounts";
                btn_Search.Text = "Search";
                lbl_New.Text = "New";
            }   
            else
            {
                btn_Item.Text = "Sản phẩm";
                btn_Discount.Text = "Khuyến mãi";
                btn_Search.Text = "Tìm kiếm";
                lbl_New.Text = "Mới";

            }    

            foreach (Item item in items)
            {
                item.UpdateView(theme, language);
            }

            foreach (Item item in apples)
            {
                item.UpdateView(theme, language);
            }

            foreach (Discount item in discounts)
            {
                item.UpdateView(theme, language);
            }

            newItems.Refresh();
        }
    }
}
