using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bTaskee
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            pic_Home.Image = Properties.Resources.home__1_;
            lbl_Home.ForeColor = Color.DarkOrange;
        }

        private void pic_Home_Click(object sender, EventArgs e)
        {
            Reset();
            pic_Home.Image = Properties.Resources.home__1_;
            lbl_Home.ForeColor = Color.DarkOrange;
            home1.BringToFront();
        }

        private void lbl_Home_Click(object sender, EventArgs e)
        {
            Reset();
            pic_Home.Image = Properties.Resources.home__1_;
            lbl_Home.ForeColor = Color.DarkOrange;
            home1.BringToFront();
        }

        private void pic_Activity_Click(object sender, EventArgs e)
        {
            Reset();
            pic_Activity.Image = Properties.Resources.activity__1_;
            lbl_Activity.ForeColor = Color.DarkOrange;
            activity1.BringToFront();
        }

        private void lbl_Activity_Click(object sender, EventArgs e)
        {
            Reset();
            pic_Activity.Image = Properties.Resources.activity__1_;
            lbl_Activity.ForeColor = Color.DarkOrange;
            activity1.BringToFront();
        }

        private void pic_Message_Click(object sender, EventArgs e)
        {
            Reset();
            pic_Message.Image = Properties.Resources.bell__1_;
            lbl_Message.ForeColor = Color.DarkOrange;
            message1.BringToFront();
        }

        private void lbl_Message_Click(object sender, EventArgs e)
        {
            Reset();
            pic_Message.Image = Properties.Resources.bell__1_;
            lbl_Message.ForeColor = Color.DarkOrange;
            message1.BringToFront();
        }

        private void pic_Account_Click(object sender, EventArgs e)
        {
            Reset();
            pic_Account.Image = Properties.Resources.user__1_;
            lbl_Account.ForeColor = Color.DarkOrange;
            account1.BringToFront();
        }

        private void lbl_Account_Click(object sender, EventArgs e)
        {
            Reset();
            pic_Account.Image = Properties.Resources.user__1_;
            lbl_Account.ForeColor = Color.DarkOrange;
            account1.BringToFront();
        }

        void Reset()
        {
            pic_Home.Image = Properties.Resources.home;
            lbl_Home.ForeColor = Color.Black;

            pic_Activity.Image = Properties.Resources.activity;
            lbl_Activity.ForeColor = Color.Black;

            pic_Message.Image = Properties.Resources.bell;
            lbl_Message.ForeColor = Color.Black;

            pic_Account.Image = Properties.Resources.user;
            lbl_Account.ForeColor = Color.Black;
        }
    }
}
