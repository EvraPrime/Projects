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
    public partial class Order : Form
    {
        string Language;

        public Order()
        {
            InitializeComponent();
        }

        public Order(int id, string total,  string address, string date, string status, Color theme, string language)
        {
            InitializeComponent();
            Language = language;
            topPanel.BackColor = theme;
            btn_Close.BackColor = theme;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
