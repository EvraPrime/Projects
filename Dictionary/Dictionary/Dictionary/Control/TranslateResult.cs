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
    }
}
