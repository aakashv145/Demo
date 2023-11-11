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
    public sealed class ResetPasswordSteps : LamdaTestStep
    {

        public ResetPasswordSteps(ScenarioContext ScenarioContext) : base(ScenarioContext)
        {
        }

        String test_url = "https://www.uat.edaid.com";

        [When(@"I click Forgotten your password\? link")]
        public void WhenIClickForgottenYourPasswordLink()
        {
            //navigate to edaid site and click login button           
            LTDriver.WebDriver.Url = test_url;
            Thread.Sleep(3000);
            LTDriver.WebDriver.FindElement(By.ClassName("sign-in")).Click();
            Thread.Sleep(5000);

            //Click forgotten password link
            LTDriver.WebDriver.FindElement(By.CssSelector("#login-form > div > div:nth-child(4) > div > a")).Click();
            Thread.Sleep(4000);
        }

        [When(@"enter a valid email")]
        public void WhenEnterAValidEmail()
        {
            //find email input box and enter email
            IWebElement emailAdd = LTDriver.WebDriver.FindElement(By.Id("Email"));
            emailAdd.Click();
            emailAdd.SendKeys("chris+ipp@edaid.com");
        }

        [When(@"I click Reset Password")]
        public void WhenIClickResetPassword()
        {
            //click reset password button
            LTDriver.WebDriver.FindElement(By.Id("send-email")).Click();
            Thread.Sleep(5000);
        }

        [Then(@"message is shown to confirm password reset email sent")]
        public void ThenMessageIsShownToConfirmPasswordResetEmailSent()
        {
            try

            {

                IWebElement element = LTDriver.WebDriver.FindElement(By.XPath("@id=['reset-form']/div/div/text()"));
                Assert.That(element.Text == ("Password recovery email has been sent."));
                Console.WriteLine("Success message displayed");
            }

            catch (Exception e)
            {
                //failure message
                MarkTestAsFailedInLT(e);
                Console.WriteLine("No success message displayed");

            }
        }
    

        [Then(@"I can click TAKE ME BACK TO SIGN IN link to return to the login page")]
        public void ThenICanClickTAKEMEBACKTOSIGNINLinkToReturnToTheLoginPage()
        {
            //click back to login and confirm page redirect
            LTDriver.WebDriver.FindElement(By.CssSelector("#reset-form > p:nth-child(3) > a")).Click();
            Thread.Sleep(5000);

            var currentPageTitle = LTDriver.WebDriver.Title.ToString();

            Console.WriteLine(currentPageTitle);
            try
            {
                //check redirection to home page
                Assert.That((currentPageTitle.Equals("EdAid- Login")), Is.True);

                Console.WriteLine("URL Correct");

            }
            catch (Exception e)
            {
                //failure message
                MarkTestAsFailedInLT(e);

                Console.WriteLine("TEST FAILED TO LOAD LOG IN");
            }
        }
    }
}
