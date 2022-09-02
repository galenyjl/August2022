using August2022.Pages;
using August2022.Utilities;
using NUnit.Framework;

namespace August2022.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Tests : CommonDriver
    {
        // page objects initialization
        HomePage homePageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();

        [Test]
        public void CreateEmployee()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.CreateEmployee(driver);
        }

        [Test]
        public void EditEmployee()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.EditEmployee(driver);
        }

        [Test]
        public void DeleteEMployee()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.DeleteEmployee(driver);
        }
    }
}
