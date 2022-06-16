using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCommentRemover
{
    internal static class CommentRemoverMain
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
                String newLines = RemoveCommentsAndEmptyLines.RemoveComments(text);
                Clipboard.SetText(newLines);
                // logic for pasting contents will go here
                //Console.WriteLine("original test is \n" + text);
                //Console.WriteLine("newLines is \n" + newLines);
            }
            else
            {
                Console.WriteLine("No text");
            }
            Environment.Exit(0);
        }
    }
}
