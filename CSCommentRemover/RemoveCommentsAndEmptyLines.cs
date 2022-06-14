using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCommentRemover
{
    static class RemoveCommentsAndEmptyLines
    {
        public static string RemoveComments(string input)
        {
            String[] lines = input.Split(new String[] { Environment.NewLine }, StringSplitOptions.None); // splits the lines of the text so we can look line by line
            String newLines = "";
            Console.WriteLine("lines is " + lines.Length);
            //int index = 0;
            foreach (String line in lines)
            {
                String newLine = line.TrimStart();
                if (newLine.Length >= 2)
                {
                    char charOne = newLine[0];
                    char charTwo = newLine[1];
                    if (!(charOne == '/') && !(charTwo == '/'))
                    {
                        newLines += newLine;
                        newLines += Environment.NewLine;
                    }
                }
                else if (newLine.Length == 1)
                {
                    newLines += newLine;
                    newLines += Environment.NewLine;
                }
            }
            newLines = newLines.Substring(0, newLines.Length - 2); // removes the last empty line
            return newLines;
        }
    }
}