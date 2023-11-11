using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;


namespace EdAid.TestAutomation.StepDefinitions
{
    [Binding]
    public sealed class StuDashPaySteps : LamdaTestStep
    { 
          public StuDashPaySteps(ScenarioContext ScenarioContext) : base(ScenarioContext)
          {
          }

             String test_url = "https://www.uat.edaid.com";
    
        [Then(@"I can click Switch Payment Account button")]
        public void ThenICanClickSwitchPaymentAccountButton()
        {
            LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(2) > div > section > div > section:nth-child(1) > div > section > div > div.col-xs-12.padding-0 > div > button")).Click();
            Thread.Sleep(500);
        }

        [Then(@"I can select an alternative payment")]
        public void ThenICanSelectAnAlternativePayment()
        {
            LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(2) > div > section > div > section:nth-child(1) > div > section > div > div > ul > li:nth-child(1) > label")).Click();
            Thread.Sleep(500);
            LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(2) > div > section > div > section:nth-child(1) > div > section > div > div > ul > li:nth-child(2) > label")).Click();
            Thread.Sleep(500);
           
        }

        [Then(@"I can click Change Default button to confirm")]
        public void ThenICanClickChangeDefaultButtonToConfirm()
        {
            LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(2) > div > section > div > section:nth-child(1) > div > section > div > div > div > button")).Click();
            Thread.Sleep(2000);
            IWebElement checkSwitched = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(2) > div > section > div > section:nth-child(1) > div > section > div > div.col-xs-12.padding-0 > div > button"));
            Assert.That(checkSwitched.Text == ("SWITCH PAYMENT ACCOUNT"));
            Console.WriteLine("Changed payment method successfully");
        }
    }
}
