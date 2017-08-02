using OpenQA.Selenium;

namespace BingRewardsSearch
{
    public class BingRewardsSearchCommand
    {

        public void NavigateToBingPage()
        {
            var Url = "https://bing.com";
            WebDriver.Driver.Navigate().GoToUrl(Url);
        }

        public void EnterSearchTerm(string searchTerm)
        {
            _bingRewardsSearchPom.SearchBox.SendKeys(searchTerm);
        }

        public void SubmitSearchOnSite()
        {
            WebDriver.Driver.FindElement(By.Id("sb_form_q")).SendKeys(Keys.Return);
        }


        private  readonly  BingRewardsSearchPom _bingRewardsSearchPom = new BingRewardsSearchPom();


    }
}
