using System.Diagnostics;

namespace ShoppingCartLibrary.Tests
{
    [TestClass]
    public class TestInitAndCleanUp
    {
        private ShoppingCart cart;
        private Item item;

        // Запускается перед стартом каждого тестирующего метода
        [TestInitialize]
        public void TestInitalize()
        {
            Debug.WriteLine("Test Initalize");
            item = new Item();
            item.Name = "Unit Test Video Lessons";
            item.Quantity = 10;

            cart = new ShoppingCart();
            cart.Add(item);
        }

        // Запускается после завершения каждого тестирующего метода
        [TestCleanup]
        public void TestCleanUp()
        {
            Debug.WriteLine("Test CleanUp");
            cart.Dispose();
        }

        [TestMethod]
        public void ShopingCart_CheckOut_ContainsItem()
        {
            CollectionAssert.Contains(cart.Items, item);
        }

        [TestMethod]
        public void ShopingCart_RemoveItem_Empty()
        {
            int expected = 0;
            cart.Remove(0);
            Assert.AreEqual(expected, cart.Count);
        }
    }
}