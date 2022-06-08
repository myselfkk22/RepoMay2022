using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using RepoMay2022.Pages;
using RepoMay2022.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoMay2022.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Tests : CommonDriver
    {
        //Page object initialization

        HomePage homepageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();

        [Test, Order(1), Description("Create Employee record with valid data")]

        
        public void CreateEmployee()
        {
            homepageObj.GoToEmployeePage(driver);
            employeePageObj.CreateEmplyee(driver);

        }
        [Test, Order(2), Description("Edit employee record created in test number 1")]
        public void EditEmployee()
        {
            homepageObj.GoToEmployeePage(driver);
            employeePageObj.EditEmployee(driver);
        }
        [Test, Order(3), Description("Delete employee record created in test number 2")]
        public void DeleteEmployee()
        {
            homepageObj.GoToEmployeePage(driver);
            employeePageObj.DeleteEmployee(driver);
        }

    }
}
