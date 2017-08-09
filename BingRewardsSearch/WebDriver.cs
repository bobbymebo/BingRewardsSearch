using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

 namespace BingRewardsSearch
{
    public class WebDriver
    {
        public static IWebDriver Driver { get; set; }
        public enum BrowserSize
        {
            Desktop,
            //Phone, --support to be added later
            //Tablet
        }

        public enum BrowserType
        {
            InternetExplorer = 0,
            Edge = 1,
            Firefox = 2,
            Chrome = 3,
        }

        public static void InitializeWebBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    Driver = new InternetExplorerDriver();
                    break;
                case BrowserType.Edge:
                    Driver = new EdgeDriver();
                    break;
                case BrowserType.Firefox:
                    var profileManager = new FirefoxProfileManager();
                    FirefoxProfile profile = profileManager.GetProfile("Selenium"); //Use preferred firefox profile - Mine is named Selenium. For more information see readme.md file.
                    Driver = new FirefoxDriver(profile);
                    break;
                case BrowserType.Chrome:
                    ChromeOptions userSessionChrome = new ChromeOptions();
                    userSessionChrome.AddArgument("user-data-dir=C:/Users/UserName/AppData/Local/Google/Chrome/User Data");
                    Driver = new ChromeDriver(userSessionChrome);
                    break;
            }
        }
    }
}