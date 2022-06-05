// See https://aka.ms/new-console-template for more information
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RepoMay2022.Pages;
using RepoMay2022.Utilities;

namespace RepoMay2022
{
    public class TM_Tests : CommonDriver 
    {

        [SetUp]
        public void LoginActions()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            //login page object initialisation and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            //home page object initialisation and definition
            HomePage homepageObj = new HomePage();
            homepageObj.GoToTMpage(driver);

        }
        [Test, Order(1), Description("Create Time and Material record with valid data in test1")]
        public void CreateTM()
        {
            // TM page object initialisation and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CeateTM(driver);
        }
        [Test, Order(2), Description("EditTM time record created in test2")]
        public void EditTM()
        {

            //Edit TM
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
        }
        [Test, Order(3),Description("Delete Time record created in test3")]
        public void DeleteTM()
        {
            //Delete TM
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);

        }
        [TearDown]
        public void CloseTestRun()
        {
            
        }




    }
    

}


















