using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using PSSkeleton.resources.capabilities;
using PSSkeleton.utils;
using PSSkeleton.config;

namespace PSSkeleton.ui
{
    class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        //private static readonly string DriverPath = PathUtils.GetPath(@"resources\drivers");
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return _driver;
            }
            private set
            {
                _driver = value;
            }
        }

        public static void InitBrowser(string browserName)
        {
            DriverName _driverName = Enum.TryParse(browserName, true, out _driverName) ? _driverName : DriverName.Firefox;
            switch (_driverName)
            {
                case DriverName.Firefox:
                    if (_driver == null)
                    {
                        _driver = new FirefoxDriver(PathUtils.GetDrivers());
                        Drivers.Add("Firefox", Driver);
                    }
                    break;

                case DriverName.IE:
                    if (_driver == null)
                    {
                        _driver = new InternetExplorerDriver(PathUtils.GetDrivers());
                        Drivers.Add("IE", Driver);
                    }
                    break;

                case DriverName.Chrome:
                    if (_driver == null)
                    {
                        _driver = new ChromeDriver(PathUtils.GetDrivers());
                        Drivers.Add("Chrome", Driver);
                    }
                    break;

                case DriverName.Edge:
                    if (_driver == null)
                    {
                        _driver = new EdgeDriver(PathUtils.GetDrivers());
                        Drivers.Add("Edge", Driver);
                    }
                    break;

                case DriverName.Safari:
                    if (_driver == null)
                    {
                        _driver = new SafariDriver(PathUtils.GetDrivers());
                        Drivers.Add("Safari", Driver);
                    }
                    break;

                case DriverName.Android:
                    if ((_driver == null))
                    {
                        IDesCapabilities androidCap = new GetAndroidCapabilities();
                        _driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), androidCap.GetCapabilities());
                        Drivers.Add("Android", Driver);
                    }
                    break;
            }
        }

        public static void LoadApplication(string url)
        {
            Driver.Url = url;
        }

        public static void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
        }
    }
}