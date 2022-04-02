using EmployeeDTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateSalary()
        {
            double expectedoutput = 150000;
            ContractEmployee conObj = new ContractEmployee(1001, "John ", "Brown", 35, 15);

            double actualOutput = conObj.CalculateSalary(15);
            Assert.AreEqual(expectedoutput, actualOutput, "Salary calculated is incorrect");
        }
    }
}
