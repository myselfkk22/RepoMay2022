using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoMay2022.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace RepoMay2022.Utilities
{
    public class CommonDriver
    {
        public  IWebDriver driver;

        LoginPage loginPageObj = new LoginPage();
       
        
        [OneTimeSetUp]
        public void LoginActions()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            //login page object initialisation and definition

            loginPageObj.LoginSteps(driver);

        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
