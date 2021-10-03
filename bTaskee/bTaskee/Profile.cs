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
    public partial class Profile : Form
    {
        public delegate void UpdateProfile(Image image, string name, string email, string phone, string address, bool isMale);

        public UpdateProfile update;

        public Profile()
        {
            InitializeComponent();
        }

        public Profile(Image image, string name, string email, string phone, string address, bool isMale)
        {
            InitializeComponent();
            pic_Profile.Image = image;
            txt_Name.Text = name;
            txt_Email.Text = email;
            txt_Phone.Text = phone;
            txt_Address.Text = address;

            if (isMale)
                rdb_Male.Checked = true;
            else
                rdb_Female.Checked = true;
        }

        private void pic_Profile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
                pic_Profile.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (update != null)
                update(pic_Profile.Image, txt_Name.Text, txt_Email.Text, txt_Phone.Text, txt_Address.Text, rdb_Male.Checked);

            this.Close();
        }
    }
}
