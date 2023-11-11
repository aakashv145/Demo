using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace EdAid.TestAutomation.StepDefinitions
{
    [Binding]
    public sealed class InviteStudentValidationSteps : LamdaTestStep
    {
        public InviteStudentValidationSteps(ScenarioContext ScenarioContext) : base(ScenarioContext)
        {
        }

        String test_url = "https://www.uat.edaid.com";

        [When(@"I enter invalid student details")]
        public void WhenIEnterInvalidStudentDetails()
        {
            //fill out invaild student information
            //first name
            LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.form > table > tbody > tr:nth-child(2) > td:nth-child(1) > input")).SendKeys("43224");
            Thread.Sleep(500);
            //last name
            LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.form > table > tbody > tr:nth-child(2) > td:nth-child(2) > input")).SendKeys("54523");
            Thread.Sleep(500);
            //email
            LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.form > table > tbody > tr:nth-child(2) > td:nth-child(3) > input")).SendKeys("chris+098wety763234");
            Thread.Sleep(500);
            //leave all other fields blank
        }

        [Then(@"Validation message is displayed")]
        public void ThenValidationMessageIsDisplayed()
        {
            //check response message is correct
            IWebElement element = LTDriver.WebDriver.FindElement(By.CssSelector("#employer-dashboard > div.confirm-modal.student-invite-modal-area > div.confirm-modal-content.invite-user-manually-modal > div.modal-bottom-info-area > p"));
            Assert.That(element.Text == ("Please complete all the above fields."));
            Console.WriteLine("Validation message successful");
            Thread.Sleep(500);
        }
    }
}
