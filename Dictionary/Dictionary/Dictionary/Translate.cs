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
        public Translate()
        {
            InitializeComponent();
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = 100;
            speechSynthesizer.Rate = 0;
            speechSynthesizer.SpeakAsync(rtbTo.Text);
        }
    }
}
