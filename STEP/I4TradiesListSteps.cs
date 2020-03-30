using System;
using TechTalk.SpecFlow;
using i4tradies.BASE;
using i4tradies.PAGE;
using OpenQA.Selenium;

namespace i4tradies
{
    [Binding]
    [Scope(Tag = "i4tradieslist")]
    public class HeadersOfI4TradiesListSteps :Hooks
    {
        public IWebDriver driver;
        public I4TradiesList browser;

        [Given(@"I navigate to I4tradies website")]
        public void GivenINavigateToItradiesWebsite()
        {
            driver = Driver;
            browser = new I4TradiesList(driver);
            browser.NavigateMethod();
        }
        
        [Given(@"I click on the list icon")]
        public void GivenIClickOnTheListIcon()
        {
            browser.ClickOnTheIcon();
        }
        
        [When(@"I click on the headers")]
        public void WhenIClickOnTheHeaders()
        {
           browser.clickheaders();
        }
        
        [Then(@"I see the headers page")]
        public void ThenISeeTheHeadersPage()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
