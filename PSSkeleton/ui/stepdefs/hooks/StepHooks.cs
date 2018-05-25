using TechTalk.SpecFlow;
using NLog;
namespace PSSkeleton.ui.stepdefs.hooks
{
    class StepHooks : AbstractStepDefs
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        [Before]
        public void InitApplication()
        {

            BrowserFactory.LoadApplication("http://www.airmoldova.md");
            logger.Trace("User was redirected to www.airmoldova.md");
        }

        [After]
        public void CloseApplication()
        {
            BrowserFactory.CloseAllDrivers();
        }
    }
}
