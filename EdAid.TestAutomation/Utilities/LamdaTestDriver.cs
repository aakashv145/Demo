using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;

namespace EdAid.TestAutomation.Utilities
{
    public class LambdaTestDriver
    {
        public IWebDriver WebDriver;

        private string _profile;
        private string _environment;
        private ScenarioContext _scenarioContext;
        
        public LambdaTestDriver(ScenarioContext scenarioContext)
        {
            this._scenarioContext = scenarioContext;
        }

        public IWebDriver Init(string profile, BrowserType browserType)
        {
            if(WebDriver != null)
            {
                return WebDriver;
            }

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json",
                             false)
                .Build();

            var caps = config.GetSection("capabilities").GetChildren();
            var envs = config.GetSection("environments").GetChildren();

            Console.WriteLine(profile + _environment);

            DriverOptions driverOptions = GetBrowserOption(browserType);

            Dictionary<string, object> ltOptions = new Dictionary<string, object>();

            foreach (var key in caps)
            {
                ltOptions.Add(key.Key, key.Value);
            }

            foreach (var key in envs)
            {
                ltOptions.Add(key.Key, key.Value);
            }

            driverOptions.AddAdditionalOption("LT:Options", ltOptions);

            String username = Environment.GetEnvironmentVariable("LT_USERNAME");
            if (username == null)
            {
                username = config.GetSection("appSettings").GetSection("username").Value;
            }

            String accesskey = Environment.GetEnvironmentVariable("LT_ACCESS_KEY");
            if (accesskey == null)
            {
                accesskey = config.GetSection("appSettings").GetSection("accesskey").Value;
            }

            driverOptions.AddAdditionalOption("username", username);
            driverOptions.AddAdditionalOption("accesskey", accesskey);
            Console.WriteLine(username);
            Console.WriteLine(accesskey);

            var server = config.GetSection("appSettings").GetSection("server").Value;
            WebDriver = new RemoteWebDriver(new Uri("http://" + username + ":" + accesskey + server + "/wd/hub/"), driverOptions);

            Console.WriteLine(WebDriver);
            return WebDriver;
        }

        public DriverOptions GetBrowserOption(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return new ChromeOptions();
                case BrowserType.Firefox:
                    return new FirefoxOptions();
                case BrowserType.Safari:
                    return new SafariOptions();
                case BrowserType.InternetExplorer:
                    return new InternetExplorerOptions();
                default:
                    return new ChromeOptions();
            }
        }



        public void Cleanup()
        {
            Console.WriteLine("Test Should stop");
            WebDriver.Quit();
        }
    }
}
