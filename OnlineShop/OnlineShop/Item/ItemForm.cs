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
    public partial class ItemForm : Form
    {
        int ID;
        string Type;
        string Language;

        public ItemForm()
        {
            InitializeComponent();
        }

        public ItemForm(Image image, int id, string name, decimal price, string type, DateTime date, Color theme, string language)
        {
            InitializeComponent();
            ID = id;
            Type = type;
            pic_Item.Image = image;
            lbl_Name.Text = name;
            lbl_Price.Text = price.ToString();
            lbl_Date.Text = date.ToShortDateString();
            topPanel.BackColor = theme;
            btn_Close.BackColor = theme;
            Language = language;

            if (language == "eg")
            {
                lbl_P.Text = "Price:";
                lbl_D.Text = "Upload Date;";
                lbl_A.Text = "Amount:";
                btn_Save.Text = "Add To Cart";
            }    
            else
            {
                lbl_P.Text = "Giá";
                lbl_D.Text = "Ngày đăng:";
                lbl_A.Text = "Số lượng:";
                btn_Save.Text = "Thêm vào giỏ hàng";
            }    
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Main.GetMain().AddToCart(new Selected(pic_Item.Image, ID, lbl_Name.Text, lbl_Price.Text, (int)num_Amount.Value, topPanel.BackColor, Language));
            this.Close();
        }
    }
}
