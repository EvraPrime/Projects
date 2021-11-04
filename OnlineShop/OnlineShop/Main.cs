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
            Phone = "052345353";
            Address = "132 Đường Nguyễn Trãi";
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
            btn_Close.BackColor = theme;
            btn_Max.BackColor = theme;
            btn_Min.BackColor = theme;

            if (language == "eg")
            {
                lbl_Settings.Text = "Settings";
                btn_Home.Text = "Home";
                btn_History.Text = "History";
                btn_Statis.Text = "Statis";
            }   
            else
            {
                lbl_Settings.Text = "Cài đặt";
                btn_Home.Text = "Trang chủ";
                btn_History.Text = "Lịch sử";
                btn_Statis.Text = "Thống kê";
            }    

            home.UpdateView(theme, language);
            settings.UpdateView(theme, language);
            history.UpdateView(theme, language);
            statis.UpdateView(theme, language);

            foreach(Selected item in cart)
            {
                item.UpdateView(theme, language);
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            home.BringToFront();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            history.BringToFront();
            history.Refresh();
        }

        private void btn_Statis_Click(object sender, EventArgs e)
        {
            statis.BringToFront();
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

        private void Main_Load(object sender, EventArgs e)
        {
            UpdateView(Color.Red, "eg");
        }

        public override void Refresh()
        {
            base.Refresh();
            history.Refresh();
        }
    }
}
