using System;
using System.Windows.Forms;

namespace TestingCommentRemover
{
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
            string shortCommentedLine = "//|";
            Clipboard.SetText(shortCommentedLine);

            Assert.IsTrue(Clipboard.GetText() == "//|");
        }
    }
}