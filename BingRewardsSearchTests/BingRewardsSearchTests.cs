using System;
using System.Threading;
using NUnit.Framework;
using BingRewardsSearch;


namespace BingRewardsSearchTests
{
    [TestFixture]
    public class BingRewardsSearchTests
    {
        [OneTimeSetUp]
        public void TextFixtureInitialize()
        {
          WebDriver.InitializeWebBrowser(WebDriver.BrowserType.Firefox);
                   _bingRewardsSearchCommand.NavigateToBingPage();
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
