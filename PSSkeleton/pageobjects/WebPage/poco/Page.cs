namespace PSSkeleton.pageobjects.WebPage
{
    class Page
    {
        public string name { get; set; }
        public string url { get; set; }
        public WebElement[] elements { get; set; }
        public ModuleBlock[] moduleBlock { get; set; }
    }
}
