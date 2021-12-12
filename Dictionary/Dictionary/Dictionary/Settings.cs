using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void pic_Click(object sender, EventArgs e)
        {
            Main.Instance.ThemeColor = ((PictureBox)sender).BackColor;
            Main.Instance.ChangeColor();
        }
    }
}
