using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using i4tradies.BASE;
using i4tradies.PAGE;

namespace i4tradies.STEP
{
    [Binding]
    [Scope(Tag = "randomfields")]
    public class RightMoveRandomFieldsSteps : Hooks
    {
        public IWebDriver driver;
        public RightMoveRandomFields BWA;

        [Given(@"I have navigate to Right Move")]
        public void GivenIHaveNavigateToRightMove()
        {
            driver = Driver;
            BWA = new RightMoveRandomFields(driver);
            BWA.NavigateToRightMove();
        }
        
        [When(@"I click on the fields using min medium maximum and mix inputs")]
        public void WhenIClickOnTheFieldsUsingMinMediumMaximumAndMixInputs()
        {
            BWA.MinInput();
            BWA.MiniInputSubmit();
            BWA.MedInput();
            BWA.MediInputSubmit();
            BWA.MaxInput();
            BWA.MaxiInputSubmit();
            BWA.MixInput();
            BWA.MixInputSubmit();
        }
        
        [Then(@"I see the page loads with search results")]
        public void ThenISeeThePageLoadsWithSearchResults()
        {
            BWA.VerifyMiniInput();
            BWA.VerifyMedInput();
            BWA.VerifyMaxInput();
            BWA.VerifymixInput();
        }
    }
}
