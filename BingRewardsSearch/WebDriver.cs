using System;
using System.Drawing;
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
            Phone,
            Tablet
        }

        public enum BrowserType
        {
            InternetExplorer = 0,
            Edge = 1,
            Firefox = 2,
            Chrome = 3,
            ChromeMobile = 4
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
                    Driver = new FirefoxDriver();
                    break;
                case BrowserType.Chrome:
                    ChromeOptions userSession = new ChromeOptions();
                    userSession.AddArgument("user-data-dir=C:\\Users\\bborisov\\AppData\\Local\\Google\\Chrome\\User Data");
                    Driver = new ChromeDriver(userSession);
                    break;
                case BrowserType.ChromeMobile:
                    Driver = new ChromeDriver();
                    break;
            }
        }

        public static void InitializeBrowserSize(BrowserSize browserSize)
        {
            switch (browserSize)
            {
               case BrowserSize.Desktop:
                    Driver.Manage().Window.Maximize();   
                    break;
                case BrowserSize.Phone:
                    Driver.Manage().Window.Size = new Size(320, 480);
                    break;
                case BrowserSize.Tablet:
                    Driver.Manage().Window.Size = new Size(768, 800);
                    break;
            }
        }

        public static void Manage()
        {
            throw new System.NotImplementedException();
        }
    }
}