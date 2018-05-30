using TechTalk.SpecFlow;

namespace PSSkeleton.ui.stepdefs.hooks
{
    class StepHooks : AbstractStepDefs
    {
        [Before]
        public void InitApplication()
        {
            string url = config.runner.url;
            BrowserFactory.LoadApplication(url);
        }

        [After]
        public void CloseApplication()
        {
            BrowserFactory.CloseAllDrivers();
        }
    }
}
