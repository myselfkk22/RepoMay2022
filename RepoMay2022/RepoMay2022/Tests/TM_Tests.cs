// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RepoMay2022.Pages;

namespace RepoMay2022
{
    public class TM_Tests
    {
        static void Main(String[] args)
        {
          //Open Chrome Browser
         IWebDriver driver= new ChromeDriver();

            //login page object initialisation and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            //home page object initialisation and definition
            HomePage homepageObj = new HomePage ();
            homepageObj.GoToTMpage(driver);

            // TM page object initialisation and definition
            TMPage tmPageObj = new TMPage ();
            tmPageObj.CeateTM(driver);

            //Edit TM
            tmPageObj.EditTM(driver);

            //Delete TM
            tmPageObj.DeleteTM(driver);


        }
    }
}















