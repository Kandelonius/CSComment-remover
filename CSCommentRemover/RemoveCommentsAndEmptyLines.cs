using System;
/*
namespace CSCommentRemover
{
    public class RemoveCommentsAndEmptyLines
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
                    bool isComment = CheckIfLineShouldBeRemoved(newLine);
                    if (isComment)
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

        public static Boolean CheckIfLineShouldBeRemoved(string line)
        {
            string firstTwo = line.Substring(0, 2);
            return firstTwo != "//";
        }

        public static void AddLine(string line, ref string newLines)
        {
            newLines += line;
            newLines += Environment.NewLine;
        }
    }
}
*/

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
                    string firstChars = newLine.Substring(0, commentChar.Length);
                    if (firstChars != commentChar)
                    {
                        if (!string.IsNullOrEmpty(newLine))
                        {
                            newLines += newLine;
                            newLines += Environment.NewLine;
                        }
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

        public static Boolean CheckIfLineShouldBeRemoved(string line)
        {
            string firstTwo = line.Substring(0, 2);
            return firstTwo != "//";
        }

        public static void AddLine(string line, ref string newLines)
        {
            newLines += line;
            newLines += Environment.NewLine;
        }
    }
}
