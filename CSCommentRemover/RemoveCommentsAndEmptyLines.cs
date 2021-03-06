using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCommentRemover
{
    public static class RemoveCommentsAndEmptyLines
    {
        public static string RemoveComments(string input)
        {
            // splits the lines of the text so we can look line by line
            String[] lines = input.Split(new String[] { Environment.NewLine }, StringSplitOptions.None); 
            String newLines = "";
            foreach (String line in lines)
            {
                String newLine = RemoveWhiteSpace(line);
                if (newLine.Length >= 2)
                {
                    string firstTwo = newLine.Substring(0, 2);
                    if (firstTwo != "//")
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
            // removes the last empty line
            newLines = newLines.Substring(0, newLines.Length - 2); 
            return newLines;
        }

        public static string RemoveWhiteSpace(string line)
        {
            try
            {
                line = line.TrimStart();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ToString());
                throw new ArgumentException("Arguments were invalid within RemoveComments method.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
            return line;
        }
    }
}