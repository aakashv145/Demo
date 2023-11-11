using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace EdAid.TestAutomation.StepDefinitions
{
    [Binding]
    public sealed class StuDashSettingsSteps : LamdaTestStep
    {
   
        public StuDashSettingsSteps(ScenarioContext ScenarioContext) : base(ScenarioContext)
        {
        }

             String test_url = "https://www.uat.edaid.com";

    [Then(@"I can click Account Settings from the hamburger menu")]
        public void ThenICanClickAccountSettingsFromTheHamburgerMenu()
        {
            Thread.Sleep(1000);
            var element = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage > div.container-fluid.dark-blue-gradient-background > nav > div > div > div.col-xs-10.nav-parts > ul > li:nth-child(2) > a > span"));

            Actions action = new Actions(LTDriver.WebDriver);
            action.MoveToElement(element).Perform();
            
            LTDriver.WebDriver.FindElement(By.CssSelector("#homepage > div.container-fluid.dark-blue-gradient-background > nav > div > div > div.col-xs-10.nav-parts > ul > li:nth-child(2) > ul > li:nth-child(2) > a")).Click();
            Thread.Sleep(8000);
        }

        [Then(@"I can view my sign up journey")]
        public void ThenICanViewMySignUpJourney()
        {
            //Settings page visible
            try
            {
                    IWebElement setting = LTDriver.WebDriver.FindElement(By.CssSelector("#preferencesApp > main > section > section.user-photo.row > h4"));
                    Assert.That(setting.Text == ("Please complete your Account Settings for EdAid verification."));
                    Console.WriteLine("Settings displayed");      
            }

            catch (Exception e)
            {
                //failure message
                MarkTestAsFailedInLT(e);

            }

            LTDriver.WebDriver.FindElement(By.CssSelector("#preferencesApp > nav > div > div > div > ul > li:nth-child(5) > a > div > div > img")).Click();
            Thread.Sleep(500);

            //Financial profile page
            try
            {
                IWebElement finance = LTDriver.WebDriver.FindElement(By.CssSelector("#preferencesApp > main > section > section > div:nth-child(3) > section > h5"));
                Assert.That(finance.Text == ("1. Do you currently have any student loans?"));
                Console.WriteLine("Financial profile displayed");
            }

            catch (Exception e)
            {
                //failure message
                MarkTestAsFailedInLT(e);

            }

            LTDriver.WebDriver.FindElement(By.CssSelector("#preferencesApp > nav > div > div > div > ul > li:nth-child(6) > a > div > div > img")).Click();
            Thread.Sleep(500);

            //Social profile page
            try
            {
                IWebElement linkedin = LTDriver.WebDriver.FindElement(By.CssSelector("#preferencesApp > main > section > section > div > a:nth-child(3) > button"));
                Assert.That(linkedin.Text == ("Connected"));
                Console.WriteLine("Social profile displayed");
            }

            catch (Exception e)
            {
                //failure message
                MarkTestAsFailedInLT(e);

            }

            LTDriver.WebDriver.FindElement(By.CssSelector("#preferencesApp > nav > div > div > div > ul > li:nth-child(7) > a > div > div > img")).Click();
            Thread.Sleep(500);

            //Payment page
            try
            {
                IWebElement linkedin = LTDriver.WebDriver.FindElement(By.CssSelector("#preferencesApp > main > section > div > h2"));
                Assert.That(linkedin.Text == ("Payments"));
                Console.WriteLine("Payments displayed");
            }

            catch (Exception e)
            {
                //failure message
                MarkTestAsFailedInLT(e);

            }

            LTDriver.WebDriver.FindElement(By.CssSelector("#preferencesApp > nav > div > div > div > ul > li:nth-child(8) > a > div > div > img")).Click();
            Thread.Sleep(500);

            //Change email page
            try
            {
                IWebElement email = LTDriver.WebDriver.FindElement(By.CssSelector("#user-pref-save-button"));
                Assert.That(email.Text == ("CHANGE EMAIL"));
                Console.WriteLine("Eamil page displayed");
            }

            catch (Exception e)
            {
                //failure message
                MarkTestAsFailedInLT(e);

            }

        }

        [Then(@"I can update my information")]
        public void ThenICanUpdateMyInformation()
        {
            LTDriver.WebDriver.FindElement(By.CssSelector("#preferencesApp > main > section > section > div:nth-child(3) > input[type=text]")).SendKeys("chris+DPP@edaid.com");
            Thread.Sleep(200);
            LTDriver.WebDriver.FindElement(By.CssSelector("#preferencesApp > main > section > section > div:nth-child(4) > input[type=text]")).SendKeys("chris+DPP@edaid.com");
            Thread.Sleep(200);
            LTDriver.WebDriver.FindElement(By.CssSelector("#preferencesApp > main > section > section > div:nth-child(5) > input[type=password]")).SendKeys("Pa55wordEdaid#");
            Thread.Sleep(200);
            LTDriver.WebDriver.FindElement(By.CssSelector("#user-pref-save-button")).Click();
            Thread.Sleep(200);

            try
            {
                IWebElement validation = LTDriver.WebDriver.FindElement(By.CssSelector("#preferencesApp > main > section > section > div:nth-child(3) > span:nth-child(3)"));
                Assert.That(validation.Text == ("Please enter a valid email address."));
                Console.WriteLine("Email change responding");
            }

            catch (Exception e)
            {
                //failure message
                MarkTestAsFailedInLT(e);

            }
        }
    }
}
