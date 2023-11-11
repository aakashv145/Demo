using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace EdAid.TestAutomation.StepDefinitions
{
    
    
        [Binding]
        public sealed class StudentLoginIPPSteps : LamdaTestStep
        {
            public StudentLoginIPPSteps(ScenarioContext ScenarioContext) : base(ScenarioContext)
            {
            }

            String test_url = "https://www.uat.edaid.com";

            [When(@"I open the EdAid Homepage")]
        public void WhenIOpenTheEdAidHomepage()
        {
            //navigate to edaid site and click login button           
            LTDriver.WebDriver.Url = test_url;
            Thread.Sleep(3000);
            LTDriver.WebDriver.FindElement(By.ClassName("sign-in")).Click();
            Thread.Sleep(5000);
        }

        [When(@"enter a valid IPP Student email")]
        public void WhenEnterAValidIPPStudentEmail()
        {
            //find email input box and enter email
            IWebElement emailAdd = LTDriver.WebDriver.FindElement(By.Id("Email"));
            emailAdd.Click();
            emailAdd.SendKeys("chris+IPP@edaid.com");
        }

        

        [Then(@"I am logged in to my account landing page")]
        public void ThenIAmLoggedInToMyAccountLandingPage()
        {
            //click continue button and wait for home page to load
            LTDriver.WebDriver.FindElement(By.Id("register-button")).Click();

            Thread.Sleep(5000);

            var currentPageTitle = LTDriver.WebDriver.Title.ToString();

            Console.WriteLine(currentPageTitle);

            try
            {
                //check redirection to home page
                Assert.That((currentPageTitle.Equals("EdAid - Fair Student Finance")), Is.True);

                Console.WriteLine("URL Correct");

            }
            catch (Exception e)
            {
                //failure message
                MarkTestAsFailedInLT(e);

                Console.WriteLine("TEST FAILED TO LOAD HOMEPAGE");
            }
        }
    }
}
