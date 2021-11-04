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
    public partial class Discount : UserControl
    {
        string Language;
        public string Code;
        public string DiscountName;
        public float Percent;
        DateTime date;

        public Discount()
        {
            InitializeComponent();
        }

        public Discount(string code, string name, float percent, DateTime exDate, DateTime reDate, Color theme, string language)
        {
            InitializeComponent();

            Percent = percent;
            Code = lbl_Code.Text = code;
            DiscountName = lbl_Name.Text = name;
            lbl_ExDate.Text = "Expiration Date: " + exDate.ToShortDateString();
            lbl_ReDate.Text = reDate.ToShortDateString();
            BackColor = theme;
            Language = language;
            date = exDate;
        }

        public void UpdateView(Color theme, string language)
        {
            BackColor = theme;
            Language = language;
            lbl_ExDate.Text = "Ngày hết hạn: " + date.ToShortDateString();
        }
    }
}
