namespace ShoppingCartLibrary.Tests
{
    [TestClass]
    public class ClassInitAndCleanup
    {
        private static ShoppingCart cart;

        // Запусукается перед стартом тестирующего метода(один раз)
        // Метод должен быть открытым, статическим и принимать параметр типа TestContext
        [ClassInitialize]
        public static void ClassInitalize(TestContext context)
        {

            Debug.WriteLine("Test Initalize");
            Item item = new Item();
            item.Name = "Unit Test Video Lessons";
            item.Quantity = 10;

            cart = new ShoppingCart();
            cart.Add(item);
        }

        // Запускается после завершения каждого тестирующего метода
        // Метод должен быть открытым, статическим и возвращать void
        [ClassCleanup]
        public static void TestCleanUp()
        {
            Debug.WriteLine("Test CleanUp");
            cart.Dispose();
        }

        [TestMethod]
        public void ShopingCart_AddToCart()
        {
            // Arrange
            Item item = new Item();
            item.Name = "Test Item";
            item.Quantity = 5;

            // Act
            cart.Add(item);

            // Assert
            Assert.AreEqual(2, cart.Count);
            Assert.AreEqual(5, item.Quantity);
        }

        [TestMethod]
        public void ShopingCart_RemoveFromCart()
        {
            // Arrange
            Item item = new Item();
            item.Name = "Test Item";
            item.Quantity = 5;
            cart.Add(item);

            // Act
            cart.Remove(cart.Items.IndexOf(item));

            // Assert
            Assert.AreEqual(2, cart.Items.Count);
        }
    }
}
