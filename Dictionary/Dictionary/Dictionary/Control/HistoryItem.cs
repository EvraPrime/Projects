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
                lbl_Act.Text = "Tra từ";
                lbl_Word.Text = word;
            }
            else
            {
                lbl_Act.Text = "Dịch từ";
                lbl_Word.Text = from;
                strTo = to;
            }   
            
            lbl_Date.Text = date;
            this.BackColor = color;
        }

        private void HistoryItem_Click(object sender, EventArgs e)
        {
            if (lbl_Act.Text == "Tra từ")
            {
                SearchView frm = new SearchView(lbl_Word.Text, this.BackColor);
                frm.ShowDialog();
            }    
            else
            {
                TranslateView frm = new TranslateView(lbl_Word.Text, strTo, this.BackColor);
                frm.ShowDialog();
            }
        }
    }
}
