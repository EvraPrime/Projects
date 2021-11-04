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
        string Language;
        Color theme = Color.Red;

        public Settings()
        {
            InitializeComponent();
        }

        public Settings(Color color, string s)
        {
            InitializeComponent();
            theme = color;
            Language = s;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txt_Name.Text = lbl_Name.Text = Main.GetMain().UserName;
            txt_Phone.Text = lbl_Phone.Text = Main.GetMain().Phone;
            txt_Address.Text = lbl_Address.Text = Main.GetMain().Address;
        }

        private void pic_Click(object sender, EventArgs e)
        {
            theme = ((PictureBox)sender).BackColor;
            Main.GetMain().UpdateView(theme, Language);
        }

        private void pic_ProfilePic_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            pic_ProfilePic.Image = Image.FromFile(openFileDialog.FileName);
        }

        public void UpdateView(Color theme, string language)
        {
            topPanel.BackColor = theme;
            Language = language;
            
            if (Language == "vn")
            {
                lbl_Title.Text = "Cài đặt";
                lbl_N.Text = "Họ tên:";
                lbl_P.Text = "Số điện thoại:";
                lbl_A.Text = "Địa chỉ:";
                if (isChanging)
                    lbl_Change.Text = "Lưu";
                else
                    lbl_Change.Text = "Thay đổi";
                lbl_Color.Text = "Màu nền";
                lbl_Language.Text = "Ngôn ngữ";
                rdb_Eng.Text = "Tiếng Anh";
                rdb_Viet.Text = "Tiếng Việt";
            }
            else
            {
                lbl_Title.Text = "Settings";
                lbl_N.Text = "Name:";
                lbl_P.Text = "Phone Number:";
                lbl_A.Text = "Address:";
                if (isChanging)
                    lbl_Change.Text = "Save";
                else
                    lbl_Change.Text = "Change Info";
                lbl_Color.Text = "Theme";
                lbl_Language.Text = "Language";
                rdb_Eng.Text = "English";
                rdb_Viet.Text = "Vietnamese";
            }
        }

        bool isChanging = false;

        private void lbl_Change_Click(object sender, EventArgs e)
        {
            isChanging = !isChanging;
            
            if (isChanging)
            {
                txt_Name.Visible = true;
                txt_Phone.Visible = true;
                txt_Address.Visible = true;
                lbl_Name.Visible = false;
                lbl_Phone.Visible = false;
                lbl_Address.Visible = false;

                if (Language == "eg")
                    lbl_Change.Text = "Save";
                else
                    lbl_Change.Text = "Lưu";
            }
            else
            {
                txt_Name.Visible = false;
                txt_Phone.Visible = false;
                txt_Address.Visible = false;
                lbl_Name.Visible = true;
                lbl_Phone.Visible = true;
                lbl_Address.Visible = true;

                Main.GetMain().Address = lbl_Address.Text = txt_Address.Text;
                Main.GetMain().Name = lbl_Name.Text = txt_Name.Text;
                Main.GetMain().Phone = lbl_Phone.Text = txt_Phone.Text;

                if (Language == "eg")
                    lbl_Change.Text = "Change Info";
                else
                    lbl_Change.Text = "Thay đổi";
            }
        }

        private void rdb_Eng_CheckedChanged(object sender, EventArgs e)
        {
            Language = "eg";
            Main.GetMain().UpdateView(theme, Language);
        }

        private void rdb_Viet_CheckedChanged(object sender, EventArgs e)
        {
            Language = "vn";
            Main.GetMain().UpdateView(theme, Language);
        }
    }
}
