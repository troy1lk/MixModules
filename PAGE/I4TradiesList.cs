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
    public class I4TradiesList
    {
        public IWebDriver Driver;
        public I4TradiesList(IWebDriver driver) 
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        public void NavigateMethod() 
        {
            Task.Delay(3000).Wait();
            Driver.Navigate().GoToUrl("https://www.i4tradies.com.au/");     
        }

        public void ClickOnTheIcon() 
        {
            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("li[class='hidden-sm hidden-xs']")).Click();
            Task.Delay(5000).Wait();
            Driver.FindElement(By.CssSelector("#accordion-1")).Click();
            Task.Delay(9000).Wait();
        }

        public void clickheaders()
        {
            Driver.FindElement(By.PartialLinkText("About Us")).Click();
            Task.Delay(5000).Wait();
            Driver.Url.Contains("https://www.i4tradies.com.au/about-australian-tradies-software-story/").Should().BeTrue();
            Task.Delay(5000).Wait();
            Driver.Navigate().Back();

            Task.Delay(5000).Wait();
            Driver.FindElement(By.CssSelector("li[class='hidden-sm hidden-xs']")).Click();
            Task.Delay(5000).Wait();

            Driver.FindElement(By.PartialLinkText("Our Team")).Click();
            Task.Delay(5000).Wait();
            Driver.Url.Contains("https://www.i4tradies.com.au/our-team/").Should().BeTrue();
            Task.Delay(5000).Wait();
            Driver.Navigate().Back();

            Task.Delay(8000).Wait();
            Driver.FindElement(By.CssSelector("li[class='hidden-sm hidden-xs']")).Click();
            Task.Delay(10000).Wait();

            Driver.FindElement(By.XPath("//ul[@id='accordion-1'] //a[@href='https://www.i4tradies.com.au/partners/']")).Click();
            Task.Delay(5000).Wait();
            Driver.Url.Contains("https://www.i4tradies.com.au/partners/").Should().BeTrue();
            Task.Delay(5000).Wait();
            Driver.Navigate().Back();

            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("li[class='hidden-sm hidden-xs']")).Click();
            Task.Delay(3000).Wait();

            Driver.FindElement(By.PartialLinkText("Investors")).Click();
            Task.Delay(5000).Wait();
            Driver.Url.Contains("https://www.i4tradies.com.au/investors/").Should().BeTrue();
            Task.Delay(3000).Wait();
            Driver.Navigate().Back();

            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("li[class='hidden-sm hidden-xs']")).Click();
            Task.Delay(3000).Wait();

            Driver.FindElement(By.PartialLinkText("Features")).Click();
            Task.Delay(5000).Wait();
            Driver.Url.Contains("https://www.i4tradies.com.au/how-this-australian-tradies-software-works").Should().BeTrue();
            Task.Delay(3000).Wait();
            Driver.Navigate().Back();

            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("li[class='hidden-sm hidden-xs']")).Click();
            Task.Delay(3000).Wait();

            Driver.FindElement(By.PartialLinkText("Articles")).Click();
            Task.Delay(5000).Wait();
            Driver.Url.Contains("https://www.i4tradies.com.au/tradies-software-resources/articles/").Should().BeTrue();
            Task.Delay(3000).Wait();
            Driver.Navigate().Back();

            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("li[class='hidden-sm hidden-xs']")).Click();
            Task.Delay(3000).Wait();

            Driver.FindElement(By.PartialLinkText("Infographics")).Click();
            Task.Delay(5000).Wait();
            Driver.Url.Contains("https://www.i4tradies.com.au/tradies-software-resources/articles/").Should().BeTrue();
            Task.Delay(3000).Wait();
            Driver.Navigate().Back();

            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("li[class='hidden-sm hidden-xs']")).Click();
            Task.Delay(3000).Wait();

            Driver.FindElement(By.PartialLinkText("Videos")).Click();
            Task.Delay(5000).Wait();
            Driver.Url.Contains("https://www.i4tradies.com.au/tradies-software-resources/video/").Should().BeTrue();
            Task.Delay(3000).Wait();
            Driver.Navigate().Back();

            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("li[class='hidden-sm hidden-xs']")).Click();
            Task.Delay(3000).Wait();

            Driver.FindElement(By.PartialLinkText("Press Releases")).Click();
            Task.Delay(5000).Wait();
            Driver.Url.Contains("https://www.i4tradies.com.au/tradies-software-resources/press-release/").Should().BeTrue();
            Task.Delay(3000).Wait();
            Driver.Navigate().Back();

            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("li[class='hidden-sm hidden-xs']")).Click();
            Task.Delay(3000).Wait();

            Driver.FindElement(By.PartialLinkText("Press Releases")).Click();
            Task.Delay(5000).Wait();
            Driver.Url.Contains("https://www.i4tradies.com.au/tradies-software-resources/press-release/").Should().BeTrue();
            Task.Delay(3000).Wait();
            Driver.Navigate().Back();

            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("li[class='hidden-sm hidden-xs']")).Click();
            Task.Delay(3000).Wait();

            Driver.FindElement(By.PartialLinkText("Tradie Life ")).Click();
            Task.Delay(5000).Wait();
            Driver.Url.Contains("https://www.i4tradies.com.au/tradie-life/").Should().BeTrue();
            Task.Delay(3000).Wait();
            Driver.Navigate().Back();







        }


    }
}
