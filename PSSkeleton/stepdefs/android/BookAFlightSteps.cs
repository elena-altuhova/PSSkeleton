using PSSkeleton.ui.stepdefs;
using TechTalk.SpecFlow;

namespace PSSkeleton.stepdefs.android
{
    [Binding]
    public class BookAFlightSteps : AbstractStepDefs
    {
        
        [Given(@"user accesses Menu")]
        public void GivenUserAccessesMenu()
        {
            //_driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

         //   _driver.FindElementByXPath("//android.widget.TextView[@content-desc='drawer_open']").Click();
         //   _driver.FindElementByAccessibilityId("drawer_open").Click();
         //   _driver.FindElementById("md.airmoldova.app:id/buttonBookFlight").Click();
         //   _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.support.v4.widget.DrawerLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button");

        }

        [Given(@"user selects '(.*)' option")]
        public void GivenUserSelectsOption(string p0)
        {
            //MobileElement el5 = (MobileElement)driver.findElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.support.v4.widget.DrawerLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout[2]");
            //MobileElement el6 = (MobileElement)driver.findElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.support.v4.widget.DrawerLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.ListView/android.widget.LinearLayout[2]/android.widget.TextView[1]");
            //  MobileElement el7 = (MobileElement)driver.findElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.support.v4.widget.DrawerLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button");
            //	md.airmoldova.app:id/buttonDrawerLogin
            //

            ////*[@id="selectedElementContainer"]/div/div[2]/div/div[3]/div/div/div/div/div/table/tbody/tr[1]/td[2]/text()
        }

        [When(@"user selects '(.*)' in Destination field")]
        public void WhenUserSelectsInDestinationField(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"available flights are shown")]
        public void ThenAvailableFlightsAreShown()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
