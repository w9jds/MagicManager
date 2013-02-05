using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicManager
{
    public partial class LegalityWin : Form
    {
        public LegalityWin(int multiverseid)
        {
            InitializeComponent();
            getLegality(multiverseid);
        }

        private void getLegality(int multiverseid)
        {
            WebRequest request = HttpWebRequest.Create("http://gatherer.wizards.com/Pages/Card/Printings.aspx?multiverseid=" + multiverseid);
            request.Method = "GET";
            using (StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                string source = reader.ReadToEnd();
                getLegality(multiverseid, source);
            }
        }

        private void getLegality(int multiversid, string source)
        {
            string legacy = null;
            List<string> formats = new List<string>();
            List<string> legalities = new List<string>();

            int tablestart = source.IndexOf("<table class=\"cardList\" cellspacing=\"0\" cellpadding=\"2\">") + 1;
            legacy = source.Substring(tablestart, (source.Length - tablestart));
            tablestart = legacy.IndexOf("<table class=\"cardList\" cellspacing=\"0\" cellpadding=\"2\">");
            int tableend = legacy.IndexOf("</table>", tablestart);
            legacy = legacy.Substring(tablestart, (tableend - tablestart));
            string[] legacysplit = legacy.Split(new string[] { "<tr class=\"cardItem evenItem\">", "<tr class=\"cardItem oddItem\">" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i < legacysplit.Length; i++)
            {
                string[] split = legacysplit[i].Split(new string[] { "<td style=\"width:40%;\">", "<td style=\"text-align:center;\">", "<td>" }, StringSplitOptions.RemoveEmptyEntries);
                int end = split[1].IndexOf("</td>");
                string format = split[1].Substring(0, end);
                format = format.Replace("\n", string.Empty);
                format = format.Replace("\r", string.Empty);
                format = format.Replace("\t", string.Empty);
                format = format.Trim();
                formats.Add(format);
                end = split[2].IndexOf("</td>");
                string legality = split[2].Substring(0, end);
                legality = legality.Replace("\n", string.Empty);
                legality = legality.Replace("\r", string.Empty);
                legality = legality.Replace("\t", string.Empty);
                legality = legality.Trim();
                legalities.Add(legality);
            }

            addLegality(formats, legalities);
        }

        private void addLegality(List<string> formats, List<string> legalities)
        {
            for (int i = 0; i < formats.Count; i++)
            {
                LegalityView.Rows.Add(formats[i], legalities[i]);
            }
        }
    }
}
