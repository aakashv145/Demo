using EdAid.TestAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace EdAid.TestAutomation.StepDefinitions
{
    [Binding]

    public sealed class InvalidPasswordStep : LamdaTestStep
    {

        public InvalidPasswordStep(ScenarioContext ScenarioContext) : base(ScenarioContext)
        {
        }

            String test_url = "https://www.uat.edaid.com";

            [When(@"I open the edaid homepage")]
            public void WhenIOpenTheEdaidHomepage()
            {
                //navigate to edaid site and click login button           
                LTDriver.WebDriver.Url = test_url;
                Thread.Sleep(3000);
                LTDriver.WebDriver.FindElement(By.ClassName("sign-in")).Click();
                Thread.Sleep(5000);
            }

            [When(@"I enter valid email")]
            public void WhenIEnterValidEmail()
            {
                //find email input box and enter email
                IWebElement emailAdd = LTDriver.WebDriver.FindElement(By.Id("Email"));
                emailAdd.Click();
                emailAdd.SendKeys("chris+DPP@edaid.com");
            }

            [When(@"I enter invalid password")]
            public void WhenIEnterInvalidPassword()
            {
                //find password input box and enter invalid password
                IWebElement emailAdd = LTDriver.WebDriver.FindElement(By.Id("Password"));
                emailAdd.Click();
                emailAdd.SendKeys("NotAPassword");
            }

            [When(@"I click login")]
            public void WhenIClickLogin()
            {
                LTDriver.WebDriver.FindElement(By.Id("register-button")).Click();

                Thread.Sleep(5000);
            }

            [Then(@"error message is displayed")]
            public void ThenErrorMessageIsDisplayed()
            {
                try

                {

                    IWebElement element = LTDriver.WebDriver.FindElement(By.CssSelector("#login-form > div > div.message-error > div > span"));
                    Assert.That(element.Text == ("Login unsuccessful"));
                    Console.WriteLine("Error message successful");
                }

                catch (Exception e)
                {
                    //failure message
                    MarkTestAsFailedInLT(e);
                    Console.WriteLine("Test Failed");
            
                }

            }
    }    
}
