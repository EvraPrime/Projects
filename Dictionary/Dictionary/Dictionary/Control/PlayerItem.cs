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
    public partial class PlayerItem : UserControl
    {
        public PlayerItem()
        {
            InitializeComponent();
        }

        public PlayerItem(string name, int point)
        {
            InitializeComponent();
            lbl_Name.Text = name;
            lbl_Point.Text = point.ToString();
        }
    }
}
