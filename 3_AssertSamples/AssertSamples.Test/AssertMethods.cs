namespace AssertSamples.Test
{
    [TestClass]
    public class AssertMethods
    {
        [TestMethod]
        public void IsSqrtTest()
        {
            // Arrange
            const double input = 4;
            const double expected = 2;

            // Act
            double actual = MyClass.GetSqrt(input);

            // Assert
            Assert.AreEqual(expected, actual, "Sqrt of {0} shold have beeт {1}!", input, expected);
        }

        [TestMethod]
        public void DeltaTest()
        {
            const double expected = 3.1;
            const double delta = 0.07;

            // 3.1622776601683795
            // 0.062..

            double actual = MyClass.GetSqrt(10);

            Assert.AreEqual(expected, actual, delta, "fail message!!!");
        }

        [TestMethod]
        public void StringAreEqualTest() 
        {
            // Arrange
            const string input = "HELLO";
            const string expected = "hello";

            // Act and assert
            // третий параметр - игнорирование регистра
            Assert.AreEqual(expected, input, true);
        }

        [TestMethod]
        public void StringSameTest()
        {
            string a = "Hello";
            string b = "Hello";

            // Проверка равенства ссылок
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void IntegersSameTest()
        {
            int i = 10;
            int j = 10;

            // Проверка равенства ссылок
            Assert.AreSame(i, j);
        }
    }
}