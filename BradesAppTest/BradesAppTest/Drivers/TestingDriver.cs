using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;

namespace BradesAppTest.Drivers
{
    public class TestingDriver
    {

        private AppiumDriver<AndroidElement> _driver;
        private ScenarioContext _currrent;

        public TestingDriver(ScenarioContext current)
        {
            _currrent = current;
        }

        public AppiumDriver<AndroidElement> Init()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "13");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "3115TF1010021259");
            //driverOptions.AddAdditionalCapability("appium:appPackage", "mx.com.appbradescard");//this ones not working somehow
            //driverOptions.AddAdditionalCapability("appium:launchActivity", "com.app.bradescard.ui.modules.login.LoginActivity");
            //                                     THIS IS THE FIRST OBSTACLE THAT I HAD appium:XXX :: OpenQA.Selenium.WebDriverException : 'automationName' can't be blank 
            driverOptions.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);

            ////for edge cases where device is otherwhere:
            ////using OpenQA.Selenium.Appium.Service
            //var AppiumService = new AppiumServiceBuilder().WithIPAddress("127.0.0.1").UsingPort(4723).Build();
            ////then
            //AppiumService.Start();//this is for "auto" starting the server


            AppiumDriver<AndroidElement> driver = new AndroidDriver<AndroidElement>(
                new Uri("http://localhost:4723/"),
                driverOptions
            );
            return driver;

        }
        //public void Cleanup()
        //{
        //    if (_driver != null)
        //    {
        //        _driver.Quit();
        //    }
        //}
    }
}
