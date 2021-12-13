using Dictionary.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Translate : UserControl
    {
        MySqlConnection con;

        public Translate()
        {
            InitializeComponent();
            con = DBUtils.GetDBConnection();
        }

        public string TranslateText(string input)
        {
            string translation = "";
            try
            {
                string url = String.Format
                ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                 "vi", "en", Uri.EscapeUriString(input));
                HttpClient httpClient = new HttpClient();
                string result = httpClient.GetStringAsync(url).Result;
                var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
                var translationItems = jsonData[0];

                if (translationItems == null)
                    return "";

                foreach (object item in translationItems)
                {
                    IEnumerable translationLineObject = item as IEnumerable;
                    IEnumerator translationLineString = translationLineObject.GetEnumerator();
                    translationLineString.MoveNext();
                    translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
                }
                if (translation.Length > 1) { translation = translation.Substring(1); };
            }
            catch
            {
                MessageBox.Show("Hmm");
                //translation = Translator.Translate(input, "vn", "en");
            }

            return translation;
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            rtbTo.Text = TranslateText(rtbFrom.Text);
            try
            {
                con.Open();
                string s = "select * from translate where fromvi='" + rtbFrom.Text.Trim() + "' ";
                MySqlCommand cmd = new MySqlCommand(s, con);
                MySqlDataReader myReader = cmd.ExecuteReader();

                if (myReader.Read())
                    pic_Favourite.BackColor = Main.Instance.ThemeColor;
                else
                    pic_Favourite.BackColor = Color.Transparent;

                s = "Insert into history (action,fromvi,toen,date) values('Translate','" + rtbFrom.Text.Trim() + "','" + rtbTo.Text.Trim() + "','" + DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "') ";
                myReader.Close();
                cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void pic_Speak_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = 100;
            speechSynthesizer.Rate = 0;
            speechSynthesizer.SpeakAsync(rtbTo.Text);
        }

        private void rtbFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTranslate.PerformClick();
            }
        }

        private void pic_Favourite_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string s = "select * from translate where fromvi='" + rtbFrom.Text.Trim() + "' ";
                MySqlCommand cmd = new MySqlCommand(s, con);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    s = "Delete from translate where fromvi='" + myReader.GetString(0) + "' ";
                    myReader.Close();
                    cmd = new MySqlCommand(s, con);
                    cmd.ExecuteNonQuery();
                    pic_Favourite.BackColor = Color.Transparent;
                }
                else
                {
                    s = "Insert into translate (fromvi,toen) values('" + rtbFrom.Text.Trim() + "','" + rtbTo.Text.Trim() + "') ";
                    myReader.Close();
                    cmd = new MySqlCommand(s, con);
                    cmd.ExecuteNonQuery();
                    pic_Favourite.BackColor = Main.Instance.ThemeColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
