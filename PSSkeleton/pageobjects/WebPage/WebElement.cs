namespace PSSkeleton.pageobjects.WebPage
{
    public class WebElement
    {
        public string Name { get; set; }
        public string LocatorType { get; set; }
        public string Locator { get; set; }

        public WebElement(string name, string locatorType, string locator)
        {
            Name = name;
            LocatorType = locatorType;
            Locator = locator;
        }
    }
}