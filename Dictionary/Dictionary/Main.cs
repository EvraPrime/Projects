using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dictionary.Helper;

namespace Dictionary
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count == 0)
                Animation.slideToDestination(this, panel1, sender as Control, Animation.Position.Center, 1, () => AddToPanel(sender));
            else
                Animation.slideToDestination(this, panel1, sender as Control, Animation.Position.Bottom, 1, () => AddToPanel(sender));
        }

        private void AddToPanel(object sender)
        {
            if (panel1.InvokeRequired)
            {
                Action safeWrite = delegate { AddToPanel(sender); };
                panel1.Invoke(safeWrite);
            }
            else
            {
                panel1.Controls.Add(sender as Control);
                
            }
        }
    }
}
