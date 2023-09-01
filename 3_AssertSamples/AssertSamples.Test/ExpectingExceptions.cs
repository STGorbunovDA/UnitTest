namespace AssertSamples.Test
{
    [TestClass]
    public class ExpectingExceptions
    {
        [ExpectedException(typeof(ArgumentNullException), "Exception was not thrown")]
        [TestMethod]
        public void MyClass_SayHello_Exception()
        {
            MyClass instance = new MyClass();
            instance.SayHello(null);
        }

        [TestMethod]
        public void MyClass_SayHello_ReturnDmitriy()
        {
            // Arrange
            MyClass instance = new MyClass();

            string expected = "Hello Dmitriy";

            // Act
            string actual = instance.SayHello("Dmitriy");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
