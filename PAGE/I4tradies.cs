using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace i4tradies.PAGE
{
   public class I4tradies
    {
        public IWebDriver Driver;
        public I4tradies (IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void NavigatetoI4trades()
        {
            Driver.Navigate().GoToUrl("https://www.i4tradies.com.au/");
        }

        public void ClickI4tradies(string link) 
        {
            switch (link) 
            {
                case "Trades Business Owner":
                    Driver.FindElement(By.PartialLinkText("Trades Business Owner")).Click();
                    Task.Delay(3000).Wait();
                break;
                  
                case "Organisations":
                    Driver.FindElement(By.PartialLinkText("Organisations")).Click();
                    Task.Delay(3000).Wait();
                    break;

                case "Trades Consumer":
                    Driver.FindElement(By.PartialLinkText("Trades Consumer")).Click();
                    Task.Delay(3000).Wait();
                    break;

                default:
                    Console.WriteLine("no such link");
                break;
            }         
        
        }
        public void verifyi4tradies(string link)
        {
            switch (link)
            {
                case "Trades Business Owner":
                    //Driver.FindElement(By.PartialLinkText("Trades Business Owner")).Text.Contains("Trades Business Owner").Should().BeTrue();
                    Driver.Url.Contains("https://www.i4tradies.com.au/trades-business-management-software").Should().BeTrue();
                    Task.Delay(3000).Wait();
                    break;

                case "Organisations ":
                    //Driver.FindElement(By.PartialLinkText("Organisations")).Text.Contains("Organisations").Should().BeTrue();
                    Driver.Url.Contains("https://www.i4tradies.com.au/property-maintenance-management-software").Should().BeTrue();
                    Task.Delay(3000).Wait();
                    break;
                    

                case "Trades Consumer":
                    // Driver.FindElement(By.PartialLinkText("Trades Business Owner")).Text.Contains("Trades Business Owner").Should().BeTrue();
                    Driver.Url.Contains("https://www.i4tradies.com.au/trades-services-consumer-app-for-managing-tradies").Should().BeTrue();
                    Task.Delay(3000).Wait();
                    break;

                default:
                    Console.WriteLine("no such link");
                    break;
            }
        }
   }

}
