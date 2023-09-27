using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace Cowmanager
{
    [Binding]
    class Hooks1
    {
        public IWebDriver driver;
              
        [BeforeScenario]
        [Obsolete]
        public void BeforeScenario()
        {
            String browserName = ConfigurationManager.AppSettings["browser"];
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://sensor-mfe.dev-cowmanager.com/company");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(70));
            ScenarioContext.Current.Add("currentDriver", driver);
        }

        [AfterScenario]
        public void Closebrowser()
        {
            driver.Quit();
        }
    }
}