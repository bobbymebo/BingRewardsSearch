using System;
using System.Threading;
using NUnit.Framework;
using BingRewardsSearch;


namespace BingRewardsSearchTests
{
    [TestFixture(true)]
    [TestFixture(false)]
    public class BingRewardsSearchTests
    {
        public bool Desktop { get; set; }

        public BingRewardsSearchTests(bool desktop)
        {
            Desktop = desktop;
        }

        [OneTimeSetUp]
        public void TextFixtureInitialize()
        {
            if (Desktop)
            {
                WebDriver.InitializeWebBrowser(WebDriver.BrowserType.Chrome);
                _bingRewardsSearchCommand.NavigateToBingPage();
            }
            else
            {
                WebDriver.InitializeWebBrowser(WebDriver.BrowserType.ChromeMobile);
                _bingRewardsSearchCommand.NavigateToBingPage();
            }
        }

        [OneTimeTearDown]
        public void TextFixtureTearDown()
        {
            WebDriver.Driver.Quit();
            WebDriver.Driver.Dispose();
        }

        [Test]
        public void UserPerformsWebSearches()
        {
            for (int search = 0; search < 30; search++)
            {
                string term = "testuser" + Guid.NewGuid().ToString();
                _bingRewardsSearchPom.SearchBox.Clear();
                _bingRewardsSearchCommand.EnterSearchTerm(term);
                _bingRewardsSearchCommand.SubmitSearchOnSite();
                Thread.Sleep(timeout);
            }
        }

        private int timeout = 2500;
        readonly BingRewardsSearchPom _bingRewardsSearchPom = new BingRewardsSearchPom();
        readonly BingRewardsSearchCommand _bingRewardsSearchCommand = new BingRewardsSearchCommand();
    }
}
