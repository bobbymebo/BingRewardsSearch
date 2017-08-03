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
          WebDriver.InitializeWebBrowser(WebDriver.BrowserType.Chrome);
                        _bingRewardsSearchCommand.NavigateToBingPage();
        }

        [OneTimeTearDown]
        public void TextFixtureTearDown()
        {
            //WebDriver.Driver.Quit();
            //WebDriver.Driver.Dispose();
        }

        [Test]
        public void UserPerformsWebSearches()
        {
            string term = "testuser" + Guid.NewGuid().ToString();
            for (int i = 0; i < 5; i++)
            {
                _bingRewardsSearchPom.SearchBox.Clear();
                _bingRewardsSearchCommand.EnterSearchTerm(term);
                _bingRewardsSearchCommand.SubmitSearchOnSite();
                Thread.Sleep(timeout);
            }

        }

        private int timeout = 2000;
        readonly BingRewardsSearchPom _bingRewardsSearchPom = new BingRewardsSearchPom();
        readonly BingRewardsSearchCommand _bingRewardsSearchCommand = new BingRewardsSearchCommand();
        readonly BingRewardsSearchDataModel _bingRewardsSearchDataModel = new BingRewardsSearchDataModel();
    }
}
