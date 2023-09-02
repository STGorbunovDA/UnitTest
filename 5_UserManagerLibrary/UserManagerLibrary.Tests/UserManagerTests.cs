using System.Xml;

namespace UserManagerLibrary.Tests
{
    public class UserManagerTests
    {
        private readonly UserManager manager = new UserManager();

        // Загрузка данных из XML-файла с помощью библиотеки Xunit.Extensions.TheoryData
        public static IEnumerable<object[]> UserTestData
        {
            get
            {
                var theoryData = new List<object[]>();

                // Создаем экземпляр XmlDocument и загружаем XML-файл
                var xmlDoc = new XmlDocument();
                xmlDoc.Load("testData.xml");

                // Получаем все элементы "User" в XML-документе
                var userNodes = xmlDoc.SelectNodes("//User");

                // Итерируем по каждому элементу User и извлекаем необходимые данные
                foreach (XmlNode userNode in userNodes)
                {
                    //string userId = userNode.SelectSingleNode("userid")?.InnerText;
                    //string telephone = userNode.SelectSingleNode("telephone")?.InnerText;
                    //string email = userNode.SelectSingleNode("email")?.InnerText;

                    string userId = userNode.Attributes["userid"]?.Value;
                    string telephone = userNode.Attributes["telephone"]?.Value;
                    string email = userNode.Attributes["email"]?.Value;

                    // Создаем массив объектов и добавляем его в TheoryData
                    object[] testData = { userId, telephone, email };
                    theoryData.Add(testData);
                }

                return theoryData;
            }
        }

        // Используем атрибут [Theory], чтобы указать, что метод является теоретическим тестом,
        // а [MemberData] для передачи данных в качестве параметров теста
        [Theory]
        [MemberData(nameof(UserTestData))]
        public void UserManager_Add_FromXML(string userId, string telephone, string email)
        {
            bool result = manager.Add(userId, telephone, email);

            Assert.True(result, "Пользователь не может быть создан!");
        }
    }
}