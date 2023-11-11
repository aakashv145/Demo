using EdAid.TestAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EdAid.TestAutomation.StepDefinitions
{
    [Binding]
    public sealed class StudentLoginHBAPSteps : LamdaTestStep
    {
        public StudentLoginHBAPSteps(ScenarioContext ScenarioContext) : base(ScenarioContext)
        {
        }

        String test_url = "https://www.uat.edaid.com";


        [When(@"open the EdAid Homepage")]
        public void WhenOpenTheEdAidHomepage()
        {
            //navigate to edaid site and click login button           
            LTDriver.WebDriver.Url = test_url;
            Thread.Sleep(3000);
            LTDriver.WebDriver.FindElement(By.ClassName("sign-in")).Click();
            Thread.Sleep(5000);
        }

        [When(@"enter a valid HBAP Student email")]
        public void WhenEnterAValidHBAPStudentEmail()
        {
            //find email input box and enter email
            IWebElement emailAdd = LTDriver.WebDriver.FindElement(By.Id("Email"));
            emailAdd.Click();
            emailAdd.SendKeys("chris+HBAP@edaid.com");
        }


        [Then(@"am logged in to my account landing page")]
        public void ThenAmLoggedInToMyAccountLandingPage()
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

        [Then(@"close the browser")]
        public void ThenCloseTheBrowser()
        {
            Thread.Sleep(1000);
        }
    }
}
