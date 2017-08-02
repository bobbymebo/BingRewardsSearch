using NUnit.Framework;
using BingRewardsSearch;


namespace BingRewardsSearchTests
{
    [TestFixture]
    public class BingRewardsSearchTests
    {

        [Test]
        public void TextFixtureInitialize()
        {
          WebDriver.InitializeWebBrowser(WebDriver.BrowserType.Chrome);
          _bingRewardsSearchCommand.NavigateToBingPage();
        }

        [OneTimeTearDown]
        public void TextFixtureTearDown()
        {
            WebDriver.Driver.Quit();
            WebDriver.Driver.Dispose();
        }

        readonly BingRewardsSearchPom _bingRewardsSearchPom = new BingRewardsSearchPom();
        readonly BingRewardsSearchCommand _bingRewardsSearchCommand = new BingRewardsSearchCommand();
        readonly BingRewardsSearchDataModel _bingRewardsSearchDataModel = new BingRewardsSearchDataModel();
    }
}
