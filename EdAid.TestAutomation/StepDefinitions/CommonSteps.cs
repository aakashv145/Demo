using EdAid.TestAutomation.Utilities;
using OpenQA.Selenium;

namespace EdAid.TestAutomation.StepDefinitions
{
    [Binding]
    public sealed class CommonSteps : LamdaTestStep
    {
        public CommonSteps(ScenarioContext ScenarioContext) : base(ScenarioContext)
        {
        }

        [Given(@"that I am on the profile (.*) and environment (.*)")]
        public void GivenThatIAmOnTheLambdaTestSampleAppAnd(string profile, BrowserType environment)
        {
            base.LTDriver.WebDriver = LTDriver.Init(profile, environment);
            base.LTDriver.WebDriver.Manage().Window.Maximize();
        }

        [When(@"I enter the valid password")]
        public void WhenIEnterTheValidPassword()

        {
            //find password input box and enter password
            IWebElement passwordStu = LTDriver.WebDriver.FindElement(By.Id("Password"));
            passwordStu.Click();
            passwordStu.SendKeys("Pa55wordEdaid#");
        }

        [Then(@"close the browser instance")]
        public void ThenCloseTheBrowserInstance()
        {
            LTDriver.WebDriver.Quit();
        }


    }
}
