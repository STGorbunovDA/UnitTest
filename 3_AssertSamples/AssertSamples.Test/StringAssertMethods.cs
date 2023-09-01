namespace AssertSamples.Test
{
    [TestClass]
    public class StringAssertMethods
    {
        [TestMethod]
        public void StringContainsTest()
        {
            // Проверка на вхождение в строку подстроки
            StringAssert.Contains("Assert samples", "sam");
        }

        [TestMethod]
        public void StringMatchesTest()
        {
            // Проверка c использованием регулярного выражения
            StringAssert.Matches("123", new Regex(@"\d{3}"));
        }

        [TestMethod]
        public void StringStartsWithTest()
        {
            // Проверка того, что строка начинается с определенного символа
            StringAssert.StartsWith("Hello world", "Hello");
        }

        [TestMethod]
        public void StringEndWithTest()
        {
            // Проверка того, что строка заканчивается определенным символом
            StringAssert.EndsWith("Hello world", "world");
        }
    }
}
