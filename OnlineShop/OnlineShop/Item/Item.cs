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
    public partial class Item : UserControl
    {
        public int ID;
        public string ItemName;
        public decimal Price;
        public string Type;
        public DateTime Date;
        public Color Theme;
        public string Language;

        public Item()
        {
            InitializeComponent();
        }

        public Item(int ID, string name, decimal price, string type, DateTime date, Color theme, string language)
        {
            InitializeComponent();

            this.ID = ID;
            this.ItemName = lbl_Name.Text = name;
            this.Price = price;
            lbl_Price.Text = price.ToString();
            this.Type = type;
            this.Date = date;
            lbl_Date.Text = date.ToShortDateString();
            Theme = theme;
            Language = language;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ItemForm form = new ItemForm(pic_Item.Image, ID, ItemName, Price, Type, Date, BackColor, Language);
            form.ShowDialog();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            BackColor = Theme;

            try
            {
                pic_Item.Image = Image.FromFile("Images/" + ID.ToString() + ".jpg");
            }
            catch
            {
                pic_Item.Image = Image.FromFile("Images/default.jpg");
            }
        }

        public void UpdateView(Color theme, string language)
        {
            BackColor = theme;
            Language = language;
        }
    }
}
