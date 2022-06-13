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
            if (Clipboard.ContainsText())
            {
                String text = Clipboard.GetText();
                String[] lines = text.Split(new String[] { Environment.NewLine }, StringSplitOptions.None);
                int index = 0;
                foreach (String line in lines)
                {
                    line.Trim();
                    Console.WriteLine(line.Trim() + index);
                    index++;
                }
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("No text");
            }
                
        }
    }
}

