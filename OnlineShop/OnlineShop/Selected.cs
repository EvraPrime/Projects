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
    public partial class Selected : UserControl
    {
        public string ItemName;
        public string Price;
        public int Amount;
        public int ID;
        public string Language;

        public Selected()
        {
            InitializeComponent();
        }

        public Selected(Image image, int id, string name, string price, int amount, Color theme, string language)
        {
            InitializeComponent();

            ID = id;
            pic_Item.Image = image;
            ItemName = lbl_Name.Text = name;
            Price = lbl_Price.Text = price;
            num_Amount.Value = Amount = amount;
            BackColor = theme;
            Language = language;
        }

        public void AddAmount(int amount)
        {
            num_Amount.Value += amount;
            Amount += amount;
        }

        public void UpdateAmount(int amount)
        {
            num_Amount.Value = amount;
            Amount = amount;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                if (this.Parent.Parent.Parent == Order.GetOrder())
                {
                    Order.GetOrder().RemoveFromCart(this);
                    Order.GetOrder().Refresh();
                }
                else
                {
                    Main.GetMain().RemoveFromCart(this);
                    this.Parent.Parent.Parent.Refresh();
                    this.Parent.Controls.Remove(this);
                }
            }
        }

        private void num_Amount_ValueChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                if (this.Parent.Parent.Parent == Order.GetOrder())
                {
                    Order.GetOrder().ChangeAmount(this, (int)num_Amount.Value);
                }
                else
                {
                    Main.GetMain().ChangeAmount(this, (int)num_Amount.Value);
                }

                this.Parent.Parent.Parent.Refresh();
            }
        }

        public void UpdateView(Color theme, string language)
        {
            BackColor = theme;
        }
    }
}
