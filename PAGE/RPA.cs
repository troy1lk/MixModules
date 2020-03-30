using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace i4tradies.PAGE
{
    public class RPA
    {
        public IWebDriver Driver;
        public RPA(IWebDriver driver) 
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void NavigatetoRPA()
        {
            Driver.Navigate().GoToUrl("http://www.rpachallenge.com/");
            Task.Delay(4000).Wait();
        }

        public void EnterDetailsOfJohn() //RPA CHALLANGE DYNAMIC INPUT FIELDS
        {
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelEmail']")).SendKeys("jsmith@itsolutions.co.uk");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelLastName']")).SendKeys("Smith");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelPhone']")).SendKeys("40716543298");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelFirstName']")).SendKeys("John");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelAddress']")).SendKeys("98 North Road");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelRole']")).SendKeys("Analyst");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelCompanyName']")).SendKeys("IT Solutions");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@class='btn uiColorButton']")).Click();
            Task.Delay(3000).Wait();
        }
            public void EnterDetailsOfJane() //RPA CHALLANGE DYNAMIC INPUT FIELDS
        { 
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelEmail']")).SendKeys("jdorsey@mc.com");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelLastName']")).SendKeys("Dorsey");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelPhone']")).SendKeys("40791345621");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelFirstName']")).SendKeys("Jane");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelAddress']")).SendKeys("11 Crown Street");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelRole']")).SendKeys("Medical Engineer");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@ng-reflect-name='labelCompanyName']")).SendKeys("MediCare");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//input[@class='btn uiColorButton']")).Click();
            Task.Delay(3000).Wait();
        }


    }
}
