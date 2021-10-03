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
    public partial class Account : UserControl
    {
        string email = "email@fake.com";
        string phone = "34637247";
        string address = "1234 gaigk";
        bool isMale = true;

        public Account()
        {
            InitializeComponent();
        }

        private void pic_Profile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(pic_Profile.Image, lbl_Profile.Text, email, phone, address, isMale);
            profile.update = new Profile.UpdateProfile(UpdateProfile);
            profile.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(pic_Profile.Image, lbl_Profile.Text, email, phone, address, isMale);
            profile.update = new Profile.UpdateProfile(UpdateProfile);
            profile.ShowDialog();
        }

        private void lbl_Profile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(pic_Profile.Image, lbl_Profile.Text, email, phone, address, isMale);
            profile.update = new Profile.UpdateProfile(UpdateProfile);
            profile.ShowDialog();
        }

        public void UpdateProfile(Image image, string name, string email, string phone, string address, bool isMale)
        {
            pic_Profile.Image = image;
            lbl_Profile.Text = name;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.isMale = isMale;
        }
    }
}
