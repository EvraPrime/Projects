using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Main : Form
    {
        private static Main _instance;
        public static Main Instance { get => _instance; set => _instance = value; }

        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            Instance = this;
        }

        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;
        private const int borderSize = 1;
        public Color ThemeColor = Color.Purple;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(new SolidBrush(ThemeColor), rc);
            e.Graphics.FillRectangle(new SolidBrush(ThemeColor), new Rectangle(0, 0, this.ClientSize.Width, borderSize));
            e.Graphics.FillRectangle(new SolidBrush(ThemeColor), new Rectangle(0, 0, borderSize, this.ClientSize.Height));
            e.Graphics.FillRectangle(new SolidBrush(ThemeColor), new Rectangle(this.ClientSize.Width - borderSize, 0, borderSize, this.ClientSize.Height));
            e.Graphics.FillRectangle(new SolidBrush(ThemeColor), new Rectangle(0, this.ClientSize.Height - borderSize, this.ClientSize.Width, borderSize));
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ChangeColor(Color.Red);
        }

        public void ChangeColor(Color theme)
        {
            ThemeColor = theme;
            btn_Exit.BackColor = ThemeColor;
            pan_Title.BackColor = ThemeColor;
            pan_Navigation.BackColor = ThemeColor;
            search.BackColor = FadingColor(ThemeColor);
            translate.BackColor = FadingColor(ThemeColor);
            SelectTab();
            this.Invalidate();
        }

        public Color FadingColor(Color rgb)
        {
            return Color.FromArgb(80, rgb.R, rgb.G, rgb.B);
        }

        public Color ChangeColorBrightness(Color rbg, float ratio)
        {
            int R = (float)rbg.R * ratio > 255 ? 255 : (int)((float)rbg.R * ratio);
            int B = (float)rbg.B * ratio > 255 ? 255 : (int)((float)rbg.B * ratio);
            int G = (float)rbg.G * ratio > 255 ? 255 : (int)((float)rbg.G * ratio);

            return Color.FromArgb(100, R, G, B);

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            search.BringToFront();
            lbl_Title.Text = "Tra từ điển";
            SelectTab();
            btn_Search.BackColor = ChangeColorBrightness(ThemeColor, 0.5f);
        }

        private void btn_Translate_Click(object sender, EventArgs e)
        {
            translate.BringToFront();
            lbl_Title.Text = "Dịch từ";
            SelectTab();
            btn_Translate.BackColor = ChangeColorBrightness(ThemeColor, 0.5f);
        }

        private void btn_Game_Click(object sender, EventArgs e)
        {
            game.BringToFront();
            lbl_Title.Text = "Game";
            SelectTab();
            btn_Game.BackColor = ChangeColorBrightness(ThemeColor, 0.5f);
        }

        private void lbl_Settings_Click(object sender, EventArgs e)
        {
            settings.BringToFront();
            search.Clear();
            lbl_Title.Text = "Cài đặt";
            SelectTab();
        }

        private void pic_Settings_Click(object sender, EventArgs e)
        {
            settings.BringToFront();
            search.Clear();
            lbl_Title.Text = "Cài đặt";
            SelectTab();
        }

        private void SelectTab()
        {
            btn_Search.BackColor = ThemeColor;
            btn_Translate.BackColor = ThemeColor;
            btn_Game.BackColor = ThemeColor;
        }
    }
}
