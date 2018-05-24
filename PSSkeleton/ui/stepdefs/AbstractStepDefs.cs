using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace PSSkeleton.ui.stepdefs
{
    [Binding]
    public class AbstractStepDefs
    {
        protected static IWebDriver _driver;

        public AbstractStepDefs()
        {
            if (_driver == null)
            {
                BrowserFactory.InitBrowser("Chrome");
                _driver = BrowserFactory.Driver;
            }
        }
    }
}
