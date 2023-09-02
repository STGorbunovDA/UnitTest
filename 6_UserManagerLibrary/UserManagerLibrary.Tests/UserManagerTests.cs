using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UserManagerLibrary.Tests
{
    // Data Driven Test - тест, который позволяет использовать для запуска данные
    // Тест запускается по одному разу на каждую запись из источника данных
    [TestClass]
    public class UserManagerTests
    {
        public TestContext TestContext { get; set; }
        private UserManager manager = new UserManager();

        // DataSource - определение источника данных.
        // 1 параметр - имя провайдера
        // 2 параметр - строка подключения или путь к файлу
        // 3 параметр - имя таблицы или элемента в XML
        // 4 параметр - как происходит доступ к записям из источника данных
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "testData.xml",
            "User",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void UserManager_Add_FromXML()
        {
            string userId = Convert.ToString(TestContext.DataRow["userid"]);
            string telephone = Convert.ToString(TestContext.DataRow["telephone"]);
            string email = Convert.ToString(TestContext.DataRow["email"]);

            bool result = manager.Add(userId, telephone, email);

            Assert.IsTrue(result, "Пользователь не может быть создан!");
        }


    }
}
