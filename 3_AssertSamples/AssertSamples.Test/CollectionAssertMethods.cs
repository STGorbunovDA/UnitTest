namespace AssertSamples.Test
{
    [TestClass]
    public class CollectionAssertMethods
    {
        static List<string> employees;

        [ClassInitialize]
        public static void InitializeCurrentTest(TestContext testContext)
        {
            employees = new List<string>();
            employees.Add("Ivan");
            employees.Add("Sergey");
            employees.Add("Anton");
            employees.Add("Roman");
        }

        [TestMethod]
        public void AllItemsAreNotNull()
        {
            // Проверка, что все элементы коллекции созданы
            CollectionAssert.AllItemsAreNotNull(employees, "Not null failed");
        }

        [TestMethod]
        public void AllItemsAreUnique()
        {
            // Проверка, значений коллекции на уникальность
            CollectionAssert.AllItemsAreUnique(employees, "Uniqueness failed");
        }

        [TestMethod]
        public void AreaEqual()
        {
            List<string> employeesTest = new List<string>();
            employeesTest.Add("Sergey");
            employeesTest.Add("Ivan");
            employeesTest.Add("Anton");
            employeesTest.Add("Roman");

            // Проверка каждого элемента на равенство
            CollectionAssert.AreEqual(employees, employeesTest);
        }

        [TestMethod]
        public void AreEquivalent()
        {
            List<string> employeesTest = new List<string>();
            employeesTest.Add("Sergey");
            employeesTest.Add("Ivan");
            employeesTest.Add("Anton");
            employeesTest.Add("Roman");

            // Проверка коллекции на наличие одинаковых элементов и кол-ву
            CollectionAssert.AreEquivalent(employees, employeesTest);
        }

        [TestMethod]
        public void Employees_Subset()
        {
            List<string> employees_Subset = new List<string>();
            employees_Subset.Add(employees[2]);

            // Проверка, что элементы коллекции входят в другую коллекцию.
            CollectionAssert.IsSubsetOf(employees_Subset, employees, "failed!");
        }
    }
}
