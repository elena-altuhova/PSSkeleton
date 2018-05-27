using Newtonsoft.Json;
using OpenQA.Selenium;
using PSSkeleton.utils;
using System.IO;
using TechTalk.SpecFlow;

namespace PSSkeleton.ui.stepdefs
{
    [Binding]
    public class AbstractStepDefs
    {
        protected static IWebDriver _driver;
        protected static dynamic config;

        public AbstractStepDefs()
        {
            if (_driver == null)
            {
                config = JsonConvert.DeserializeObject(File.ReadAllText(PathUtils.GetPath(@"config\config.json")));
                string browser = config.runner.browser;
                BrowserFactory.InitBrowser(browser);
                _driver = BrowserFactory.Driver;
            }
        }
    }
}
