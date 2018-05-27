using OpenQA.Selenium.Remote;
using Newtonsoft.Json;
using System.IO;
using PSSkeleton.utils;

namespace PSSkeleton.resources.capabilities
{
    class GetAndroidCapabilities : IDesCapabilities
    {
        public DesiredCapabilities GetCapabilities()
        {
            var cap = new DesiredCapabilities();
            AndroidCapabilities androidCapabilities;
            using (StreamReader file = File.OpenText(PathUtils.GetPath(@"config\capabilities\android_capabilities.json")))
            {
                JsonSerializer serializer = new JsonSerializer();
                androidCapabilities = (AndroidCapabilities)serializer.Deserialize(file, typeof(AndroidCapabilities));
            }

            cap.SetCapability("platformName", androidCapabilities.platformName);
            cap.SetCapability("deviceName", androidCapabilities.deviceName);
            cap.SetCapability("appPackage", androidCapabilities.appPackage);
            cap.SetCapability("appActivity", androidCapabilities.appActivity);

            return cap;
        }
    }
}
