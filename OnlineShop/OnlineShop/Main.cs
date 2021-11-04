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
    public partial class Main : Form
    {
        private static Main instance;
        List<Selected> cart;

        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Main()
        {
            InitializeComponent();
            cart = new List<Selected>();
            instance = this;
            UserName = "Nguyen Van A";
            Phone = "02405353";
            Address = "132 grgrkarg";
        }

        public static Main GetMain()
        {
            return instance;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pic_Settings_Click(object sender, EventArgs e)
        {
            settings.BringToFront();
        }

        public void UpdateView(Color theme, string language)
        {
            panel1.BackColor = theme;
            panel2.BackColor = theme;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            home.BringToFront();
        }

        public void AddToCart(Selected item)
        {
            foreach (Selected selected in cart)
            {
                if (selected.ItemName == item.ItemName)
                {
                    selected.AddAmount(item.Amount);
                    return;
                }
            }

            cart.Add(item);
        }

        public void ChangeAmount(Selected item, int amount)
        {
            foreach (Selected selected in cart)
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
            cart.Remove(item);
        }

        public decimal GetTotal()
        {
            decimal result = 0;

            foreach (Selected selected in cart)
            {
                result += decimal.Parse(selected.Price) * (decimal)selected.Amount;
            }

            return result;
        }

        public List<Selected> GetCart()
        {
            return cart;
        }
    }
}
