using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Control
{
    public partial class TranslateResult : UserControl
    {
        string strTo;
        public TranslateResult()
        {
            InitializeComponent();
        }

        public TranslateResult(string from, string to, Color color)
        {
            InitializeComponent();
            label1.Text = from;
            strTo = to;
            this.BackColor = color;
        }

        private void TranslateResult_Click(object sender, EventArgs e)
        {
            TranslateView frm = new TranslateView(label1.Text, strTo, this.BackColor);
            frm.ShowDialog();
            Favourite.Instance.UpdateResult();
        }
    }
}
