using EdAid.TestAutomation.Utilities;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;
using System.Linq.Expressions;
using TechTalk.SpecFlow;


namespace EdAid.TestAutomation.StepDefinitions
{
    [Binding]
    public sealed class InvalidEmailSteps : LamdaTestStep
    {

        public InvalidEmailSteps(ScenarioContext ScenarioContext) : base(ScenarioContext)
        {
        }

        String test_url = "https://www.uat.edaid.com";

        
    
        [When(@"I open th edaid homepage")]
        public void WhenIOpenThEdaidHomepage()
        {
            //navigate to edaid site and click login button           
            LTDriver.WebDriver.Url = test_url;
            Thread.Sleep(3000);
            LTDriver.WebDriver.FindElement(By.ClassName("sign-in")).Click();
            Thread.Sleep(5000);
        }

        [When(@"I enter invalid email")]
        public void WhenIEnterInvalidEmail()
        {
            //find email input box and enter email
            IWebElement emailAdd = LTDriver.WebDriver.FindElement(By.Id("Email"));
            emailAdd.Click();
            emailAdd.SendKeys("InVaLiDeMaIl00@edaid.com");
        }

        [When(@"I select login")]
        public void WhenISelectLogin()
        {
            LTDriver.WebDriver.FindElement(By.Id("register-button")).Click();
            Thread.Sleep(5000);
        }

        [Then(@"error message displayed")]
        public void ThenErrorMessageDisplayed()
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
