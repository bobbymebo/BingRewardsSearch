﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Drawing;

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
                    var profileManager = new FirefoxProfileManager();
                    FirefoxProfile profile = profileManager.GetProfile("Selenium"); //Use preferred firefox profile - Mine is named Selenium. For more information see readme.md file.
                    Driver = new FirefoxDriver(profile);
                    break;
                case BrowserType.Chrome:
                    ChromeOptions userSessionChrome = new ChromeOptions();
                    userSessionChrome.AddArgument("user-data-dir=C:/Users/UserName/AppData/Local/Google/Chrome/User Data");
                    //userSessionChrome.AddArguments("--headless");
                    //userSessionChrome.AddArguments("--disable-gpu");
                    Driver = new ChromeDriver(userSessionChrome);
                    break;
                case BrowserType.ChromeMobile:
                    ChromeOptions userSessionChromeMobile = new ChromeOptions();
                    //userSessionChromeMobile.AddArguments("no-sandbox");
                    userSessionChromeMobile.AddArgument("user-data-dir=C:/Users/UserName/AppData/Local/Google/Chrome/User Data");
                    userSessionChromeMobile.EnableMobileEmulation("Nexus 7");
                    Driver = new ChromeDriver(userSessionChromeMobile);
                    break;
            }
        }


        public static void SetBrowserSize(BrowserSize size)
        {
            switch (size)
            {
                case BrowserSize.Desktop:
                    Driver.Manage().Window.Maximize();
                    break;
                case BrowserSize.Tablet:
                    Driver.Manage().Window.Size = new Size(768, 800);
                    break;
                case BrowserSize.Phone:
                    Driver.Manage().Window.Size = new Size(320, 480);
                    break;
            }

        }

    }
}