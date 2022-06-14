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
            //home page object initialisation and definition
            homepageObj.GoToTMpage(driver);
           
            // TM page object initialisation and definition
            tmPageObj.CeateTM(driver);
        }
        [Test, Order(2), Description("EditTM Material record created in test number 1")]
        public void EditTM()
        {
            // TM page object initialisation and definition
            homepageObj.GoToTMpage(driver);
            
            //Edit TM
            tmPageObj.EditTM(driver,"dummy0","dummy1", "dummy2");
        }
        [Test, Order(3), Description("Delete Material record in test number 2")]
        public void DeleteTM()
        {
            // TM page object initialisation and definition
            homepageObj.GoToTMpage(driver);

            //Delete TM
            tmPageObj.DeleteTM(driver);
        }
        //[Test, Order(4), Description("Create time record with valid data")]
        //public void CreateTimeRecord()
        //{
        //    //home page object initialisation and definition
        //    homepageObj.GoToTMpage(driver);

        //    // // TM page object initialisation and definition
        //    tmPageObj.CreateTimeRecord(driver);
        //}
        //[Test, Order(5), Description("Edit time record in test number 1")]
        //public void EditTimeRecord()
        //{
        //    //home page object initialisation and definition
        //    homepageObj.GoToTMpage(driver);

        //    //Edit Time record
        //    tmPageObj.EditTimeRecord(driver);     
        //}
        //[Test, Order(6), Description("Delete time record in test number 2")]
        //public void DeleteTimeRecord()
        //{
        //    //home page object initialisation and definition
        //    homepageObj.GoToTMpage(driver);

        //    //Delete time record
        //    tmPageObj.DeleteTimeRecord(driver);

        //}


    }
    

}


















