using OpenQA.Selenium;

namespace PSSkeleton.pageobjects
{
    class AbstractPageObject
    {
        protected static IWebDriver _driver;

        public AbstractPageObject(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
