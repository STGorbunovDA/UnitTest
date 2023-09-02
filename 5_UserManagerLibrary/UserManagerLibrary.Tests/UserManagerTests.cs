using System.Xml;

namespace UserManagerLibrary.Tests
{
    public class UserManagerTests
    {
        private readonly UserManager manager = new UserManager();

        // �������� ������ �� XML-����� � ������� ���������� Xunit.Extensions.TheoryData
        public static IEnumerable<object[]> UserTestData
        {
            get
            {
                var theoryData = new List<object[]>();

                // ������� ��������� XmlDocument � ��������� XML-����
                var xmlDoc = new XmlDocument();
                xmlDoc.Load("testData.xml");

                // �������� ��� �������� "User" � XML-���������
                var userNodes = xmlDoc.SelectNodes("//User");

                // ��������� �� ������� �������� User � ��������� ����������� ������
                foreach (XmlNode userNode in userNodes)
                {
                    //string userId = userNode.SelectSingleNode("userid")?.InnerText;
                    //string telephone = userNode.SelectSingleNode("telephone")?.InnerText;
                    //string email = userNode.SelectSingleNode("email")?.InnerText;

                    string userId = userNode.Attributes["userid"]?.Value;
                    string telephone = userNode.Attributes["telephone"]?.Value;
                    string email = userNode.Attributes["email"]?.Value;

                    // ������� ������ �������� � ��������� ��� � TheoryData
                    object[] testData = { userId, telephone, email };
                    theoryData.Add(testData);
                }

                return theoryData;
            }
        }

        // ���������� ������� [Theory], ����� �������, ��� ����� �������� ������������� ������,
        // � [MemberData] ��� �������� ������ � �������� ���������� �����
        [Theory]
        [MemberData(nameof(UserTestData))]
        public void UserManager_Add_FromXML(string userId, string telephone, string email)
        {
            bool result = manager.Add(userId, telephone, email);

            Assert.True(result, "������������ �� ����� ���� ������!");
        }
    }
}