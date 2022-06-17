using System;
using System.Windows.Forms;

namespace TestingCommentRemover
{
    [STAThread]
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void CommentedLinesShowOnClipboard()
        {
            Clipboard.Clear();
            string shortCommentedLine = "//|";
            Clipboard.SetText(shortCommentedLine);
            //string clipboardContents = Clipboard.GetData();
            Assert.IsTrue(Clipboard.ContainsText());
        }
    }
}