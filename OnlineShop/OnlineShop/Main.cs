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
        
        public Main()
        {
            InitializeComponent();
            instance = this;
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
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            home.BringToFront();
        }
    }
}
