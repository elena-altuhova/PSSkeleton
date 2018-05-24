using TechTalk.SpecFlow;

namespace PSSkeleton.ui.stepdefs.hooks
{
    class StepHooks : AbstractStepDefs
    {
        [Before]
        public void InitApplication()
        {
            BrowserFactory.LoadApplication("http://www.airmoldova.md");
        }

        [After]
        public void CloseApplication()
        {
            BrowserFactory.CloseAllDrivers();
        }
    }
}
