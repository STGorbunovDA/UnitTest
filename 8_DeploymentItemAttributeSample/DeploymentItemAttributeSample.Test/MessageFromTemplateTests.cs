namespace DeploymentItemAttributeSample.Test
{
    [TestClass]
    public class MessageFromTemplateTests
    {
        [TestMethod]
        [DeploymentItem("Files\\ExamCreatedResult.txt")]
        [DeploymentItem("Files\\ExamCreatedTemplate.txt")]
        public void FromTemplate_PassTestValue_StringFromTemlateReturned()
        {
            MessageFromTemplate messageBuilder = new MessageFromTemplate();
            messageBuilder.TemplateFolder = ".";

            string expectedResult = File.ReadAllText("ExamCreatedResult.txt");

            string actualResult = messageBuilder.FromTemplate("TestExam", "Beginer", new DateTime(2000, 1, 1));

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}