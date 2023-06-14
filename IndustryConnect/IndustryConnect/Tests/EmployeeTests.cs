using IndustryConnect.Pages;
using IndustryConnect.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustryConnect.Tests
{
    [TestFixture]
    [Parallelizable]
    public class EmployeeTests : CommonDrivers
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();

        [SetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();

            //login page object initialization and definition
            loginPageObj.loginSteps();

            //home page object initialization and definition
            homePageObj.goToEmployeePage();
        }

        [Test, Order(1), Description("Create Employees Test")]
        public void CreateEmployeeTest()
        {
            employeePageObj.CreateEmployee();
        }

        [Test, Order(2), Description("Edit Employees Test")]

        public void EditEmployeeTest()
        {
            employeePageObj.EditEmployee();
        }

        [Test, Order(3), Description("Delete Employees Test")]
        public void DeleteEmployeeTest()
        {
            employeePageObj.DeleteEmployee();
        }

        [TearDown]
        public void ClosingStep()
        {
            driver.Quit();
        }
    }
}
