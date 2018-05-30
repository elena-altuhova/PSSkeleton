using OpenQA.Selenium;
using PSSkeleton.utils;
using System.Collections.Generic;
using System.IO;

namespace PSSkeleton.pageobjects.WebPage
{
    class WebPageObject
    {
        public string PageName;
        public string Url;
        public IDictionary<string, WebElement> Elements = new Dictionary<string, WebElement>();
        private IWebDriver _driver;

        public WebPageObject(string jsonName, IWebDriver driver)
        {
            _driver = driver;
            Page page = JsonUtils.ParseJson<Page>(getPageObject(jsonName));
          
            PageName = page.name;
            Url = page.url;

            GetAllElementsFromModules(GetModules(page));
            GetAllElementsFromPage(page);
        }

        private string getPageObject(string jsonName)
        {
            string path = PathUtils.GetPageObject(jsonName);
            if (File.Exists(path))
            {
                return path;
            } else
            {
                throw new FileNotFoundException($"{jsonName} Page Object is not implemented or name is wrong.");
            }
        }

        public IWebElement GetElement(string elementName)
        {
            WebElement element = Elements[elementName];
            return _driver.FindElement(Locators.GetLocator(element.LocatorType, element.Locator));
        }

        private IDictionary<string, Module> GetModules(Page page)
        {
            IDictionary<string, Module> modules = new Dictionary<string, Module>();
            foreach (ModuleBlock moduleBlock in page.moduleBlock)
            {
                string path = PathUtils.GetModule(moduleBlock.Name);
                if (File.Exists(path))
                {
                    Module module = JsonUtils.ParseJson<Module>(PathUtils.GetModule(moduleBlock.Name));
                    modules.Add(moduleBlock.Locator, module);
                } else
                {
                    throw new FileNotFoundException($"{moduleBlock.Name} Module is not implemented or name is wrong.");
                }

            }
            return modules;
        }

        private void GetAllElementsFromModules(IDictionary<string, Module> modules)
        {
            foreach (KeyValuePair<string, Module> module in modules)
            {
                foreach (WebElement webElement in module.Value.elements)
                {
                    webElement.Locator = module.Key + webElement.Locator;
                    Elements.Add(webElement.Name, webElement);
                }
            }
        }

        private void GetAllElementsFromPage(Page page)
        {
            foreach (WebElement webElement in page.elements)
            {
                Elements.Add(webElement.Name, webElement);
            }
        }
    }
}
