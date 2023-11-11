using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace EdAid.TestAutomation.StepDefinitions
{
    [Binding]

    public sealed class InviteStudentSteps : LamdaTestStep
    {
        public InviteStudentSteps(ScenarioContext ScenarioContext) : base(ScenarioContext)
        {
        }

        String test_url = "https://www.uat.edaid.com";

        [When(@"I go to the EdAid Landing Page")]
        public void WhenIGoToTheEdAidLandingPage()
        {
            //navigate to edaid site and click login button           
            LTDriver.WebDriver.Url = test_url;
            Thread.Sleep(3000);
            LTDriver.WebDriver.FindElement(By.ClassName("sign-in")).Click();
            Thread.Sleep(5000);
        }

        [When(@"I enter a valid school admin email")]
        public void WhenIEnterAValidSchoolAdminEmail()
        {
            //find email input box and enter email
            IWebElement emailAdd = LTDriver.WebDriver.FindElement(By.Id("Email"));
            emailAdd.Click();
            emailAdd.SendKeys("chris+autosch@edaid.com");
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            //click continue button and wait for home page to load
            LTDriver.WebDriver.FindElement(By.Id("register-button")).Click();

            Thread.Sleep(3000);
        }

        [When(@"I click the invite student button")]
        public void WhenIClickTheInviteStudentButton()
        {
            //click inite student button
            LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.col-xs-12.tab-buttons-area > h4 > span.col-xs-12.search > button:nth-child(6) > span:nth-child(2)")).Click();
            Thread.Sleep(1000);
        }

        [When(@"I enter valid student details")]
        public void WhenIEnterValidStudentDetails()
        {
            //generate a valid random email
            Random r = new Random();
            int rInt = r.Next(0, 1000000);
            string start = new("chris+");
            string end = new("@edaid.com");
            var email = start + rInt + end;
            Console.WriteLine(email);


            //fill out student information
            //first name
            LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.form > table > tbody > tr:nth-child(2) > td:nth-child(1) > input")).SendKeys("Automation");
            Thread.Sleep(500);
            //last name
            LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.form > table > tbody > tr:nth-child(2) > td:nth-child(2) > input")).SendKeys("Test");
            Thread.Sleep(500);
            //email
            LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.form > table > tbody > tr:nth-child(2) > td:nth-child(3) > input")).SendKeys(email);
            Thread.Sleep(500);
            //select campus
            LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.form > table > tbody > tr:nth-child(2) > td:nth-child(4) > select > option:nth-child(2)")).Click();
            Thread.Sleep(500);
            //select course
            LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.form > table > tbody > tr:nth-child(2) > td:nth-child(5) > div > div > select > option:nth-child(3)")).Click();
            Thread.Sleep(500);
            //select start date
            LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.form > table > tbody > tr:nth-child(2) > td:nth-child(6) > div > select > option:nth-child(2)")).Click();
            Thread.Sleep(500);
            //select payment option
            LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.form > table > tbody > tr:nth-child(2) > td:nth-child(7) > div > select > option:nth-child(2)")).Click();
            Thread.Sleep(500);
            

        }

        [When(@"I click Invite Student button")]
        public void WhenIClickInviteStudentButton()
        {
            LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.confirm-modal-button-wrapper > button")).Click();
            Thread.Sleep(6000);
        }

        [Then(@"Success message is displayed")]
        public void ThenSuccessMessageIsDisplayed()
        {
            //check response message is correct
            IWebElement element = LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.modal-bottom-info-area > p"));
            Assert.That(element.Text == ("Students successfully invited."));
            Console.WriteLine("Invite successful");
            Thread.Sleep(500);
        }

        [Then(@"I can close the Invite window")]
        public void ThenICanCloseTheInviteWindow()
        {
            //close invite box
            LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.student-invite-modal-close")).Click();
            Thread.Sleep(500);

        }
    }
}
