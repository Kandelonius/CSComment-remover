using CSCommentRemover;

namespace CommentRemoverTests
{
    [TestClass]
    [TestCategory("Comment Removal")]
    public class UnitTest1
    {
        string multiLineTestWithComments;
        string multiLineTestWithoutComments;
        string stringAfterCommentRemovedMethod;
        [TestInitialize]
        public void RunsBeforeEveryTest ()
        {
            multiLineTestWithComments = $"line one{Environment.NewLine}//line two{Environment.NewLine}line three";
            multiLineTestWithoutComments = $"line one{Environment.NewLine}line two{Environment.NewLine}line three";
        }
        [TestMethod]
        [TestCategory("Positive")]
        public void CommentRemoverRemovesComments()
        {
            stringAfterCommentRemovedMethod = RemoveCommentsAndEmptyLines.RemoveComments(multiLineTestWithComments);
            Assert.IsTrue(stringAfterCommentRemovedMethod == $"line one{Environment.NewLine}line three");
        }

        [TestMethod]
        [TestCategory("Positive")]
        //[ExpectedException (typeof (AssertFailedException))]
        public void LeadingWhitespaceIsRemoved()
        {
            string lineWithLeadingWhiteSpace = RemoveCommentsAndEmptyLines.RemoveWhiteSpace("  <-- two single spaces?");

            Assert.AreEqual("<-- two single spaces?", lineWithLeadingWhiteSpace);
        }

        [TestMethod]
        [TestCategory("Negative")]
        public void IfThereAreNoCommentsLinesAreNotRemoved()
        {
            stringAfterCommentRemovedMethod = RemoveCommentsAndEmptyLines.RemoveComments(multiLineTestWithoutComments);
            Assert.IsFalse(stringAfterCommentRemovedMethod == $"line one{Environment.NewLine}line three");
        }
    }
}