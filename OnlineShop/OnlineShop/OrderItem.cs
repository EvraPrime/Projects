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

        public OrderItem()
        {
            InitializeComponent();
        }

        public OrderItem(int id, decimal total, string address, DateTime date, string status)
        {
            InitializeComponent();
            ID = id;
            lbl_ID.Text = id.ToString();
            lbl_Total.Text = total.ToString();
            lbl_Address.Text = address;
            lbl_Date.Text = date.ToShortDateString();
            Status = status;
        }

        private void OrderItem_Click(object sender, EventArgs e)
        {
            Order form = new Order(ID, lbl_Total.Text, lbl_Address.Text, lbl_Date.Text, Status, BackColor, Language);
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
        }

        public void UpdateView(Color theme, string language)
        {
            BackColor = theme;
            Language = language;
        }
    }
}
