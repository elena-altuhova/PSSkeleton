using OpenQA.Selenium;

namespace PSSkeleton.pageobjects
{
    class LandingPage : AbstractPageObject
    {
        public LandingPage(IWebDriver driver) : base(driver) { }

        IWebElement login => _driver.FindElement(By.XPath("//a[text()='Login']"));
        IWebElement rezervariLogin => _driver.FindElement(By.XPath("//*[@id='login']"));
        IWebElement email => _driver.FindElement(By.XPath("//*[@id='emailLogin']"));
        IWebElement password => _driver.FindElement(By.XPath("//*[@id='passwordLogin']"));
        IWebElement loginButton => _driver.FindElement(By.XPath("//*[@id='login-box']/form/button"));
        IWebElement createAccount => _driver.FindElement(By.XPath("//*[@id='login-box']/form/div[3]/a[1]"));
        IWebElement errorMessage => _driver.FindElement(By.XPath("//div[1]/div/div/div/div/ul/li"));
        //"//div[contains(@class, 'system-message error')]"));

        public void ClickLogin() { login.Click(); }

        public void ClickRezervariLogin() { rezervariLogin.Click(); }

        public void SetEmailLogin(string emailLogin) { email.SendKeys(emailLogin); }

        public void SetPassword(string passwordLogin) { password.SendKeys(passwordLogin); }

        public void ClickOk() { loginButton.Click(); }

        public void ClickCreateAccount() { createAccount.Click(); }

        public string GetErrorMessage() { return errorMessage.Text; }
    }
}
