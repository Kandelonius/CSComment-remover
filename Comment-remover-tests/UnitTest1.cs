using CSCommentRemover;

namespace Comment_remover_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CommentRemoverRemovesComments()
        {
            string multiLineTestWithComments = $"line one{Environment.NewLine}//line two{Environment.NewLine}line three";
            string multiLineTestWithoutComments = RemoveCommentsAndEmptyLines.RemoveComments(multiLineTestWithComments);
            Console.WriteLine(multiLineTestWithoutComments);
            Assert.IsTrue(multiLineTestWithoutComments == $"line one{Environment.NewLine}line three");
        }
    }
}