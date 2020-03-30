using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using i4tradies.PAGE;
using i4tradies.BASE;

namespace i4tradies.STEP
{
    [Binding]
    [Scope(Tag = "submit")]
    public class RPASteps : Hooks
    {
        public IWebDriver driver;
        public RPA enter;

        [Given(@"I navigate to RPA")]
        public void GivenINavigateToRPA()
        {
            driver = Driver;
            enter = new RPA(driver);
            enter.NavigatetoRPA();
        }

        
        [Given(@"I enter login details")]
        public void GivenIEnterLoginDetails()
        {
            enter.EnterDetailsOfJohn();
        }
        
        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            enter.EnterDetailsOfJane();
        }
        
        [Then(@"I verify the RPA page")]
        public void ThenIVerifyTheRPAPage()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
