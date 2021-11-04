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

        public Home()
        {
            InitializeComponent();
            items = new List<Item>();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            newItems.Controls.Clear();
            newItems.Controls.AddRange(items.ToArray());
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
            var con = DAL.GetDBConnection();
            con.Open();

            string sql = "SELECT * FROM Item";
            
            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();
            Item temp;
            while (rdr.Read())
            {
                temp = new Item(rdr.GetInt32(0), rdr.GetString(1), rdr.GetDecimal(2), rdr.GetString(3), rdr.GetDateTime(4));
                items.Add(temp);
                searchBox.Items.Add(rdr.GetString(1));
            }

            con.Close();
            newItems.Controls.AddRange(items.ToArray());
        }

        private void pic_Search_Click(object sender, EventArgs e)
        {
            searchItems.Controls.Clear();
            foreach (Item item in items)
            {
                if (item.ItemName.Contains(searchBox.Text))
                    searchItems.Controls.Add(item);
            }
            ChangeUI();
        }

        private void btn_Laptop_Click(object sender, EventArgs e)
        {
            searchItems.Controls.Clear();
            foreach (Item item in items)
            {
                if (item.Type == "Laptop")
                    searchItems.Controls.Add(item);
            }
            ChangeUI();
        }

        private void btn_Android_Click(object sender, EventArgs e)
        {
            searchItems.Controls.Clear();
            foreach (Item item in items)
            {
                if (item.Type == "Android")
                    searchItems.Controls.Add(item);
            }
            ChangeUI();
        }

        private void btn_Apple_Click(object sender, EventArgs e)
        {
            searchItems.Controls.Clear();
            foreach (Item item in items)
            {
                if (item.Type == "Apple")
                    searchItems.Controls.Add(item);
            }
            ChangeUI();
        }

        private void btn_TV_Click(object sender, EventArgs e)
        {
            searchItems.Controls.Clear();
            foreach (Item item in items)
            {
                if (item.Type == "TV")
                    searchItems.Controls.Add(item);
            }
            ChangeUI();
        }

        private void ChangeUI()
        {
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
            string str = "Cart doesn't have any item!!!";

            if (x.Length == 0)
                MessageBox.Show(str);
            else
            {
                Cart form = new Cart(x);
                form.ShowDialog();
            }
        }
    }
}
