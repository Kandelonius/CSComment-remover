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
        string multiLineTestWithOctothorpComments;
        [TestInitialize]
        public void RunsBeforeEveryTest ()
        {
            multiLineTestWithComments = $"line one{Environment.NewLine}//line two{Environment.NewLine}line three";
            multiLineTestWithoutComments = $"line one{Environment.NewLine}line two{Environment.NewLine}line three";
            multiLineTestWithOctothorpComments = $"line one{Environment.NewLine}#line two{Environment.NewLine}line three";
        }
        [TestMethod]
        [TestCategory("Positive")]
        public void CommentRemoverRemovesComments()
        {
            stringAfterCommentRemovedMethod = RemoveCommentsAndEmptyLines.RemoveComments(multiLineTestWithComments, "//");
            Assert.IsTrue(stringAfterCommentRemovedMethod == $"line one{Environment.NewLine}line three");
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void LeadingWhitespaceIsRemoved()
        {
            string lineWithLeadingWhiteSpace = RemoveCommentsAndEmptyLines.RemoveWhiteSpace("  <-- two single spaces?");

            Assert.AreEqual("<-- two single spaces?", lineWithLeadingWhiteSpace);
        }

        // Test fails because I assert the string will still have whitespace, this shows the test doesn't implicitly ignore the leading whitespace. Could also be done with a string length comparison.
        [TestMethod]
        [TestCategory("Negative")]
        [ExpectedException (typeof (AssertFailedException))]
        public void VerifyLeadingWhitespaceIsRemovedTestIsValid()
        {
            string lineWithLeadingWhiteSpace = RemoveCommentsAndEmptyLines.RemoveWhiteSpace("  <-- two single spaces?");

            Assert.AreEqual("  <-- two single spaces?", lineWithLeadingWhiteSpace);
        }

        [TestMethod]
        [TestCategory("Negative")]
        public void IfThereAreNoCommentsLinesAreNotRemoved()
        {
            stringAfterCommentRemovedMethod = RemoveCommentsAndEmptyLines.RemoveComments(multiLineTestWithoutComments, "//");
            Assert.IsFalse(stringAfterCommentRemovedMethod == $"line one{Environment.NewLine}line three");
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void CommentRemoverRemovesOctothorpComments()
        {
            stringAfterCommentRemovedMethod = RemoveCommentsAndEmptyLines.RemoveComments(multiLineTestWithOctothorpComments, "#");
            Assert.IsTrue(stringAfterCommentRemovedMethod == $"line one{Environment.NewLine}line three");
        }
    }
}