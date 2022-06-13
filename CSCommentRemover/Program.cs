using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCommentRemover
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //String returnHtmlText = null;
            //if (Clipboard.ContainsText(TextDataFormat.Html))
            //{
            //    returnHtmlText = Clipboard.GetText(TextDataFormat.Html);
            //    Clipboard.SetText(replacementHtmlText, TextDataFormat.Html);
            //}
            //return returnHtmlText;
            if (Clipboard.ContainsText())
            {
                String text = Clipboard.GetText();
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("No text");
            }
                
        }
    }
}

