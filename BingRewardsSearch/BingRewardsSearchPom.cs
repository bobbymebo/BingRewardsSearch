using OpenQA.Selenium;

namespace BingRewardsSearch
{
    public class BingRewardsSearchPom
    {
        public IWebElement SearchBox => WebDriver.Driver.FindElement(By.Id("sb_form_q"));
        public IWebElement SubmitButton => WebDriver.Driver.FindElement(By.Id("sb_form_go"));
    }
}
