namespace TestContextSamples
{
    [TestClass]
    public class MyTestSample
    {
        // TestContext используетс€ дл€ хранени€ информации о текущем юнит тесте
        // ѕри тестировании веб сервисов URL
        // ѕри тестировании ASP.NET приложений - предоставл€ет доступ к ASP странице
        // ѕри использовании Data Driven тестов предоставл€ет доступ к источнику данных

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