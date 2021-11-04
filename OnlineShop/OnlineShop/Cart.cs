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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        public Cart(Selected[] selecteds)
        {
            InitializeComponent();

            selectedItems.Controls.AddRange(selecteds);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
