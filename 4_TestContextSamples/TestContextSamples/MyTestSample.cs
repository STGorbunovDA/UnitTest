namespace TestContextSamples
{
    [TestClass]
    public class MyTestSample
    {
        // TestContext ������������ ��� �������� ���������� � ������� ���� �����
        // ��� ������������ ��� �������� URL
        // ��� ������������ ASP.NET ���������� - ������������� ������ � ASP ��������
        // ��� ������������� Data Driven ������ ������������� ������ � ��������� ������

        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("TestRunDirectory {0}", TestContext.TestRunDirectory);
            TestContext.WriteLine("TestName {0}", TestContext.TestName);
            TestContext.WriteLine("CurrentTestOutcome {0}", TestContext.CurrentTestOutcome);
        }

        [TestCleanup]
        public void CleanUp()
        {
            TestContext.WriteLine("TestName (CleanUp) {0}", TestContext.TestName);
            TestContext.WriteLine("CurrentTestOutcome (CleanUp) {0}", TestContext.CurrentTestOutcome);
        }
    }
}