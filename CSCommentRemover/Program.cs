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
                String text = Clipboard.GetText(); // pulls the text from the clipboard to remove single line comments from
                String[] lines = text.Split(new String[] { Environment.NewLine }, StringSplitOptions.None); // splits the lines of the text so we can look line by line
                int index = 0;
                foreach (String line in lines)
                {
                    String newLine = line.TrimStart();
                    if (newLine.Length > 1)
                    {
                        char charOne = newLine[0];
                        char charTwo = newLine[1];
                        if (!(charOne == '/') && !(charTwo == '/'))
                        {
                            Console.WriteLine("one is " + charOne + " and two is " + charTwo);
                            //Console.WriteLine(line.Trim() + index);
                            //index++;
                        }
                        //Console.WriteLine(line.Trim() + index);
                    }
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

