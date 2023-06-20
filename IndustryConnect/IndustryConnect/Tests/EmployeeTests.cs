using IndustryConnect.Pages;
using IndustryConnect.Utilities;
using NUnit.Framework;

namespace IndustryConnect.Tests
{
    [TestFixture]
    //[Parallelizable]
    public class EmployeeTests : CommonDrivers
    {
        HomePage homePageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();

        
        [Test, Order(1), Description("Create Employees Test")]
        public void CreateEmployeeTest()
        {
            homePageObj.goToEmployeePage();
            employeePageObj.CreateEmployee();
        }

        [Test, Order(2), Description("Edit Employees Test")]

        public void EditEmployeeTest()
        {
            homePageObj.goToEmployeePage();
            employeePageObj.EditEmployee();
        }

        [Test, Order(3), Description("Delete Employees Test")]
        public void DeleteEmployeeTest()
        {
            homePageObj.goToEmployeePage();
            employeePageObj.DeleteEmployee();
        }

    }
}
