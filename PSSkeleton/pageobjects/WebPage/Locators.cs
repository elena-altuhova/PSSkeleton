using OpenQA.Selenium;
using System;

namespace PSSkeleton.pageobjects.WebPage
{
    public enum LocatorType
    {
        xpath,
        css,
        id,
        classname,
        tag
    }

    public class Locators
    {
        private static LocatorType _locatorType;

        public static By GetLocator(string locatorType, string locator)
        {
            if (Enum.TryParse(locatorType, out _locatorType))
            {
                switch (_locatorType)
                {
                    case LocatorType.xpath:
                        return By.XPath(locator);
                    case LocatorType.css:
                        return By.CssSelector(locator);
                    case LocatorType.id:
                        return By.Id(locator);
                    case LocatorType.classname:
                        return By.ClassName(locator);
                    case LocatorType.tag:
                        return By.TagName(locator);
                    default:
                        return By.XPath(locator);
                }
            } else
            {
                throw new ArgumentException("Invalid locator type.");
            }
        }
    }
}
