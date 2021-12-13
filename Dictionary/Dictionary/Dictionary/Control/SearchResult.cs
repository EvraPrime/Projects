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
    public partial class SearchResult : UserControl
    {
        public SearchResult()
        {
            InitializeComponent();
        }

        public SearchResult(string word, Color color)
        {
            InitializeComponent();
            label1.Text = word;
            this.BackColor = color;
        }

        private void SearchResult_Click(object sender, EventArgs e)
        {
            SearchView frm = new SearchView(label1.Text, this.BackColor);
            frm.ShowDialog();
            Favourite.Instance.UpdateResult();
        }
    }
}
