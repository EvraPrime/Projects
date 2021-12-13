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
    public partial class HistoryItem : UserControl
    {
        string strTo = "";
        public HistoryItem()
        {
            InitializeComponent();
        }

        public HistoryItem(string act, string word, string from, string to, string date, Color color)
        {
            InitializeComponent();
            if (act == "Search")
            {
                label1.Text = "Tra từ";
                label2.Text = word;
            }
            else
            {
                label1.Text = "Dịch từ";
                label2.Text = from;
                strTo = to;
            }   
            
            label3.Text = date;
            this.BackColor = color;
        }
    }
}
