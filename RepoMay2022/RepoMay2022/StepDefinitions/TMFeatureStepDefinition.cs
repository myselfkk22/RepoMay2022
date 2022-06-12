using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using RepoMay2022.Pages;
using RepoMay2022.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace RepoMay2022.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinition : CommonDriver
    {
        [Given(@"I logged into turn poratl successfully")]
        public void GivenILoggedIntoTurnPoratlSuccessfully()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            //login page object initialisation and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {

            // TM page object initialisation and definition
            HomePage homepageObj = new HomePage();
            homepageObj.GoToTMpage(driver);
        }

        [When(@"I created a new Time and Material record")]
        public void WhenICreateNewTimeAndMaterialRecord()
        {
            //home page object initialisation and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CeateTM(driver);

        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage tmPageObj = new TMPage();

            string newCode = tmPageObj.GetNewCode(driver);
            string newTypeCode = tmPageObj.GetNewTypeCode(driver);
            string newDescription = tmPageObj.GetNewDescription(driver);
            string newPrice = tmPageObj.GetNewPrice(driver);


            Assert.That(newCode == "Material Code1", "Actual code and expected code do not match.");
            Assert.That(newTypeCode == "M", "Actual typecode and expected type code do not match.");
            Assert.That(newDescription == "First Material Record", "Actual description and expected description do not match.");
            Assert.That(newPrice == "$22.00", "Actual price and expected price do not match.");

        }

        [When(@"I update '([^']*)','([^']*)','([^']*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string p0, string p1, string p2)
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver, p0, p1, p2);
        }

        [Then(@"the record should have the updated '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string p0, string p1, string p2)
        {
            TMPage tmPageObj = new TMPage();

            string editedDescription = tmPageObj.GetEditedDescription(driver);
            string editedCode = tmPageObj.GetEditedCode(driver);
            string editedPrice = tmPageObj.GetEditedPrice(driver);

            Assert.That(editedDescription == p0, "Actual description and expected description do not match.");
            Assert.That(editedCode == p1, "Actual code and expected code do not match.");
            Assert.That(editedPrice == p2, "Actual price and expected price do not match.");

        }

    }
}
