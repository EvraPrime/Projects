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
        private static Color _themeColor = Color.Purple;
        public static Color ThemeColor 
        { 
            get => _themeColor; 
            set
            {
                _themeColor = value;
                Instance.ChangeColor();
            }
        }

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
            ChangeColor();
        }

        private void ChangeColor()
        {
            btn_Exit.BackColor = ThemeColor;
            pan_Title.BackColor = ThemeColor;
            pan_Navigation.BackColor = ThemeColor;
            search.BackColor = BrightenColor(ThemeColor);
            translate.BackColor = BrightenColor(ThemeColor);
            this.Invalidate();
        }

        public Color BrightenColor(Color rgb)
        {
            return Color.FromArgb(80, rgb.R, rgb.G, rgb.B);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            search.BringToFront();
            lbl_Title.Text = "Tra từ điển";
        }

        private void btn_Translate_Click(object sender, EventArgs e)
        {
            translate.BringToFront();
            lbl_Title.Text = "Dịch từ";
        }

        private void btn_Game_Click(object sender, EventArgs e)
        {
            game.BringToFront();
            lbl_Title.Text = "Game";
        }

        private void lbl_Settings_Click(object sender, EventArgs e)
        {
            settings.BringToFront();
            search.Clear();
            lbl_Title.Text = "Cài đặt";
        }

        private void pic_Settings_Click(object sender, EventArgs e)
        {
            settings.BringToFront();
            search.Clear();
            lbl_Title.Text = "Cài đặt";
        }
    }
}
