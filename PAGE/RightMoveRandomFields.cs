using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

namespace i4tradies.PAGE
{
    public class RightMoveRandomFields
    {
        public IWebDriver Driver;
        public RightMoveRandomFields(IWebDriver driver) 
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void NavigateToRightMove() 
        {
            Driver.Navigate().GoToUrl("https://www.rightmove.co.uk/");
        }

        public void MinInput()
        {
            Driver.FindElement(By.Id("searchLocation")).SendKeys("RM8");
            Driver.FindElement(By.Id("buy")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.Id("radius")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//option[@value='0.0']")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.Id("minPrice")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='maxPrice'] //option[@value='50000']")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.Id("minBedrooms")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='maxBedrooms']//option[contains(text(),'Studio')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='displayPropertyType']//option[contains(text(),'Any')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='maxDaysSinceAdded']//option[contains(text(),'Anytime')]")).Click();
            Task.Delay(2000).Wait();          
        }
        public void MiniInputSubmit() 
        {
            Driver.FindElement(By.CssSelector("#submit")).Click();
            Task.Delay(2000).Wait();
        }
        public void VerifyMiniInput() 
        {
            IWebElement MiniInput = Driver.FindElement(By.ClassName("searchTitle-heading"));
            Task.Delay(2000).Wait();
            MiniInput.Displayed.Should().BeTrue();
            Task.Delay(2000).Wait();         
        }

        //Mini input ends here.................................

        public void MedInput()
        {
            Driver.Navigate().GoToUrl("https://www.rightmove.co.uk/");
            Task.Delay(4000).Wait();
            Driver.FindElement(By.Id("searchLocation")).SendKeys("RM8");
            Driver.FindElement(By.Id("buy")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.Id("radius")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//option[@value='15.0']")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='minPrice']//option[contains(text(),'200,000')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='maxPrice'] //option[@value='1000000']")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='minBedrooms']//option[contains(text(),'1')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='maxBedrooms']//option[contains(text(),'3')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='displayPropertyType']//option[contains(text(),'Bungalows')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='maxDaysSinceAdded']//option[contains(text(),'Last 3 days')]")).Click();
            Task.Delay(2000).Wait();
        }
        public void MediInputSubmit()
        {
            Driver.FindElement(By.CssSelector("#submit")).Click();
            Task.Delay(2000).Wait();
        }
        public void VerifyMedInput()
        {
            IWebElement MedInput = Driver.FindElement(By.ClassName("info-message"));
            Task.Delay(2000).Wait();
            MedInput.Displayed.Should().BeTrue();
        }

        //Medi input ends here.................................


        public void MaxInput()
        {
            Driver.Navigate().GoToUrl("https://www.rightmove.co.uk/");
            Task.Delay(4000).Wait();
            Driver.FindElement(By.Id("searchLocation")).SendKeys("RM8");
            Driver.FindElement(By.Id("buy")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.Id("radius")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//option[@value='40.0']")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='minPrice']//option[contains(text(),'50,000')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='maxPrice'] //option[@value='20000000']")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='minBedrooms']//option[contains(text(),'Studio')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='maxBedrooms']//option[contains(text(),'5')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='displayPropertyType']//option[contains(text(),'Houses')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='maxDaysSinceAdded']//option[contains(text(),'Last 14 days')]")).Click();
            Task.Delay(2000).Wait();
        }
        public void MaxiInputSubmit()
        {
            Driver.FindElement(By.CssSelector("#submit")).Click();
            Task.Delay(2000).Wait();
        }
        public void VerifyMaxInput()
        {
            IWebElement MedInput = Driver.FindElement(By.ClassName("propertyCard-moreInfoFeaturedTitle"));
            Task.Delay(2000).Wait();
            MedInput.Displayed.Should().BeTrue();
        }
        //Medi input ends here.................................

        public void MixInput()
        {
            Driver.Navigate().GoToUrl("https://www.rightmove.co.uk/");
            Task.Delay(4000).Wait();
            Driver.FindElement(By.Id("searchLocation")).SendKeys("RM8");
            Driver.FindElement(By.Id("buy")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.Id("radius")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//option[@value='20.0']")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='minPrice']//option[contains(text(),'150,000')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='maxPrice'] //option[@value='450000']")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='minBedrooms']//option[contains(text(),'3')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='maxBedrooms']//option[contains(text(),'4')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='displayPropertyType']//option[contains(text(),'Any')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//select[@id='maxDaysSinceAdded']//option[contains(text(),'Anytime')]")).Click();
            Task.Delay(2000).Wait();
            Driver.FindElement(By.ClassName("tickbox--indicator")).Click();
            Task.Delay(2000).Wait();
        }
        public void MixInputSubmit()
        {
            Driver.FindElement(By.CssSelector("#submit")).Click();
            Task.Delay(2000).Wait();
        }
        public void VerifymixInput()
        {
            IWebElement MedInput = Driver.FindElement(By.XPath("//div[@id='radiusFilterBar']//select[@name='radius'] //option[contains(text(),'20')]"));
            Task.Delay(2000).Wait();
            MedInput.Displayed.Should().BeTrue();
        }
    }
}
