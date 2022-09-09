using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCommentRemover
{
    public static class CommentRemoverMain
    {
        [STAThread]
        static void Main()
        {
            // on virtual branch
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            if (Clipboard.ContainsText())
            {
                // pulls the text from the clipboard from which we'll remove single line comments
                String text = Clipboard.GetText();
                // calls the remove comments method passing the captured text and assigns the result to newLines variable
                String newLines = RemoveCommentsAndEmptyLines.RemoveComments(text);
                // changes the text on the clipboard to the uncommented text
                Clipboard.SetText(newLines);
            }
            else
            {
                Application.Run(new Form1());
                //Console.WriteLine("No text");
            }
            Environment.Exit(0);
        }
    }
}
