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
    public partial class Settings : UserControl
    {
        string language;
        Color theme;

        public Settings()
        {
            InitializeComponent();
        }

        public Settings(Color color, string s)
        {
            InitializeComponent();
            theme = color;
            language = s;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.BackColor = theme;
        }

        private void pic_Click(object sender, EventArgs e)
        {
            theme = ((PictureBox)sender).BackColor;
            Main.GetMain().UpdateView(theme, language);
        }
    }
}
