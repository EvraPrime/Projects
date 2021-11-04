using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class Cart : Form
    {
        string Language;

        public Cart()
        {
            InitializeComponent();
        }

        public Cart(Selected[] selecteds, Color theme, string language)
        {
            InitializeComponent();

            topPanel.BackColor = theme;
            btn_Close.BackColor = theme;
            selectedItems.Controls.AddRange(selecteds);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            lbl_Name.Text = Main.GetMain().UserName;
            lbl_Phone.Text = Main.GetMain().Phone;
            lbl_Address.Text = Main.GetMain().Address;
            lbl_Sum.Text = (Main.GetMain().GetTotal() + decimal.Parse(lbl_Ship.Text)).ToString();
            
        }

        public override void Refresh()
        {
            base.Refresh();
            lbl_Sum.Text = (Main.GetMain().GetTotal() + decimal.Parse(lbl_Ship.Text)).ToString();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            var x = Main.GetMain();
            string str = "Cart doesn't have any item!!!";
            string s = "Oders success!!!";

            if (x.GetCart().Count == 0)
            {
                MessageBox.Show(str);
            }
            else
            {
                var con = DAL.GetDBConnection();
                con.Open();
                string sqlBill = "INSERT INTO Bill (Total, Address, Date, Status) "
                               + "VALUES (@Total, @Address, @Date, @Status)";
                StringBuilder sqlOrder = new StringBuilder();
                sqlOrder.Append("INSERT INTO OrderDetail (BillID, ItemID, Amount) VALUES");

                try
                {
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = sqlBill;

                    cmd.Parameters.Add("@Total", MySqlDbType.Decimal).Value = x.GetTotal() + 10000;
                    cmd.Parameters.Add("@Address", MySqlDbType.VarChar).Value = lbl_Address.Text;
                    cmd.Parameters.Add("@Date", MySqlDbType.Date).Value = DateTime.Now;
                    cmd.Parameters.Add("@Status", MySqlDbType.VarChar).Value = "Ordering";

                    cmd.ExecuteNonQuery();
                    ///////
                    string sql = "SELECT * FROM Bill ORDER BY ID DESC LIMIT 1";

                    cmd = new MySqlCommand(sql, con);

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    int temp;
                    rdr.Read();
                    temp = rdr.GetInt32(0);
                    rdr.Close();
                    rdr.Dispose();
                    ///////
                    cmd = con.CreateCommand();
                    foreach (Selected selected in x.GetCart())
                    {
                        sqlOrder.AppendFormat("({0}, {1}, {2}) ,", temp, selected.ID, selected.Amount);
                    }
                    sqlOrder.Remove(sqlOrder.Length - 1, 1);
                    string sqlCommand = sqlOrder.ToString();
                    cmd.CommandText = sqlCommand;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(s);
                    x.GetCart().Clear();
                    this.Close();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error: " + er  + '\n' + er.StackTrace);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
