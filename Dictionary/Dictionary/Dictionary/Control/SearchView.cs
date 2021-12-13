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
    public partial class SearchView : Form
    {
        public SearchView()
        {
            InitializeComponent();
        }

        public SearchView(string word, Color color)
        {
            InitializeComponent();
            lbl_Word.Text = word;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
