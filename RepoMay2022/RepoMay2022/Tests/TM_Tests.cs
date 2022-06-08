// See https://aka.ms/new-console-template for more information
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RepoMay2022.Pages;
using RepoMay2022.Utilities;

namespace RepoMay2022
{ 

    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver 
    {
        //Page Object initialization
       
        TMPage tmPageObj = new TMPage();
        HomePage homepageObj = new HomePage();

        [Test, Order(1), Description("Create Time and Material record with valid data")]
        public void CreateTM()
        {
            // TM page object initialisation and definition
            homepageObj.GoToTMpage(driver);
            
            //home page object initialisation and definition
             tmPageObj.CeateTM(driver);
        }
        [Test, Order(2), Description("EditTM time record created in test number 1")]
        public void EditTM()
        {
            // TM page object initialisation and definition
            homepageObj.GoToTMpage(driver);
            
            //Edit TM
            tmPageObj.EditTM(driver);
        }
        [Test, Order(3),Description("Delete Time record edited in test number 2")]
        public void DeleteTM()
        {
            // TM page object initialisation and definition
            homepageObj.GoToTMpage(driver);

            //Delete TM

            tmPageObj.DeleteTM(driver);

        }
       




    }
    

}


















