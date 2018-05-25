using NUnit.Framework;
using PSSkeleton.pageobjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using NLog;

namespace PSSkeleton.ui.stepdefs
{
    public class AirMoldovaDummyTestingSteps : AbstractStepDefs
    {
        
        LandingPage landingPage;

        [Given(@"user is populating login form with (.*) and (.*) combination")]
        public void UserIsPopulatingLoginForm(string login, string password)
        {
            landingPage = new LandingPage(_driver);
            landingPage.ClickLogin();
            landingPage.ClickRezervariLogin();
            landingPage.SetEmailLogin(login);
            landingPage.SetPassword(password);
        }
        
        [When(@"user clicks (Ok|Close) button")]
        public void UserClicksButton(string buttonName)
        {
            landingPage.ClickOk();
        }

        [Then(@"(.*) error message appears")]
        public void ErrorMessageAppears(String errorMessage)
        {
            Thread.Sleep(1000);
            Assert.AreEqual(landingPage.GetErrorMessage(), errorMessage, "Error message is wrong or empty");
        }
    }
}
