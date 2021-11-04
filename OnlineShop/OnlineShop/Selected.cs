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
        public Selected()
        {
            InitializeComponent();
        }

        public Selected(Image image, string name, string price, int amount)
        {
            InitializeComponent();

            pic_Item.Image = image;
            lbl_Name.Text = name;
            lbl_Price.Text = price;
            num_Amount.Value = amount;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
