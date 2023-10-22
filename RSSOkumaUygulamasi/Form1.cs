using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSOkumaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            List<News> Records = XMLCevir();
            lst_Baslik.DataSource = Records;
        }

        private List<News> XMLCevir()
        {
            List<News> NewsRecord = new List<News>();
            XDocument XMLSource = XDocument.Load(textRSS_URL.Text);
            List<XElement> Rows = XMLSource.Descendants("item").ToList();   // item olduğuna nasıl karar verdik: XML sağladığımız kaynağın sitesine gittik >> (https://sabah.com.tr/rss/spor.xml) 
                                                                            // burada inleceme yaptığmızda verilerin "<item></item>" şeklinde tutulduğunu gördük. :D
                                                                                            
            foreach ( XElement item in Rows )
            {
                News Temp = new News();
                Temp.Header         = item.Element("title").Value;
                Temp.Link           = item.Element("link").Value;
                Temp.Description    = item.Element("description").Value;
                NewsRecord.Add( Temp );
            }
            return NewsRecord;
        }

        private void lst_Baslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox selectedIndex = (ListBox)sender;
            News selectedNews = selectedIndex.SelectedItem as News;
            web_Browser.DocumentText = selectedNews.Description;
        }
    }
}
