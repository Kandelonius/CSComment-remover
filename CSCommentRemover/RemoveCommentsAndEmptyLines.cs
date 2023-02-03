using System;
using System.Text.RegularExpressions;

namespace CSCommentRemover
{
    public class RemoveCommentsAndEmptyLines
    {
        public static string RemoveComments(string input, string commentChar)
        {
            // splits the lines of the text so we can look line by line
            String[] lines = input.Split(new String[] { Environment.NewLine }, StringSplitOptions.None);
            String newLines = "";
            foreach (String line in lines)
            {
                String newLine = RemoveWhiteSpace(line);
                if (newLine.Length >= commentChar.Length)
                {
                    bool isComment = CheckIfLineShouldBeRemoved(newLine, commentChar);
                    if (!isComment)
                    {
                        AddLine(newLine, ref newLines);
                    }
                }
                else if (newLine.Length == 1)
                {
                    AddLine(newLine, ref newLines);
                }
            }
            // removes the last empty line
            newLines = newLines.Substring(0, newLines.Length - 2);
            return newLines;

            /* 
             * working on regex below which might be able to remove lines as expected
             * currently it will remove the text, but keeps the line as well as all of the leading
             * whitespace.
             */

            /* 
             * sets the pattern which says ignoring leading whitespace if a line starts with 
             * the comment character(s) then that line should be removed. After that return
             * that line replaced with an empty string and extend this to all lines which match
             * this pattern.
             */ 
            //string pattern = $@"^\s*{commentChar}.*";
            //return Regex.Replace(input, pattern, "", RegexOptions.Multiline);
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

        public static Boolean CheckIfLineShouldBeRemoved(string line, string commentChar)
        {
            string lineStart = line.Substring(0, commentChar.Length);
            return lineStart == commentChar;
        }

        public static void AddLine(string line, ref string newLines)
        {
            newLines += line;
            newLines += Environment.NewLine;
        }
    }
}
