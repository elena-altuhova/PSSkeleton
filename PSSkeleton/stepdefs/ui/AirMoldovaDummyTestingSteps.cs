using NUnit.Framework;
using PSSkeleton.pageobjects.WebPage;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace PSSkeleton.ui.stepdefs
{
    public class AirMoldovaDummyTestingSteps : AbstractStepDefs
    {
        WebPageObject LandingPage;

        [Given(@"user is populating login form with (.*) and (.*) combination")]
        public void UserIsPopulatingLoginForm(string login, string password)
        {
            LandingPage = new WebPageObject("LandingPage", _driver);
            LandingPage.GetElement("login").Click();
            LandingPage.GetElement("rezervariLogin").Click();
            LandingPage.GetElement("email").SendKeys(login);
            LandingPage.GetElement("password").SendKeys(password);
        }
        
        [When(@"user clicks (Ok|Close) button")]
        public void UserClicksButton(string buttonName)
        {
            LandingPage.GetElement("okButton").Click();
        }

        [Then(@"(.*) error message appears")]
        public void ErrorMessageAppears(String errorMessage)
        {
            Thread.Sleep(1000);
            Assert.AreEqual(LandingPage.GetElement("errorMessage").Text, errorMessage, "Error message is wrong or empty");
        }
    }
}
