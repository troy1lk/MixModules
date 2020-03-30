using System;
using TechTalk.SpecFlow;
using i4tradies.BASE;
using i4tradies.PAGE;
using OpenQA.Selenium;

namespace i4tradies.STEP
{
    [Binding]
  
    [Scope(Tag = "headers")]
    public class I4TradesSteps : Hooks
    {
        public IWebDriver driver;
        public I4tradies browser;

        [Given(@"I navigate to I4trades")]
        public void GivenINavigateToItrades()
        {
            driver = Driver;
            browser = new I4tradies(driver);
            browser.NavigatetoI4trades();
        }

        [Given(@"I click on (.*)")]
        public void GivenIClickOn(string link)
        {
            browser.ClickI4tradies(link);
        }

        [Then(@"I see (.*) page")]
        public void ThenISeePage(string link)
        {
            browser.verifyi4tradies(link);
        }
    }
}
