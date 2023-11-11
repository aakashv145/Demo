using EdAid.TestAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EdAid.TestAutomation.StepDefinitions
{
    [Binding]
    public sealed class ToDoApp : LamdaTestStep
    {
        public ToDoApp(ScenarioContext ScenarioContext) : base(ScenarioContext)
        {
        }

        String itemName = "MI";
        String test_url = "https://lambdatest.github.io/sample-todo-app/";

        [Then(@"I am on the test url")]
        public void ThenIAmOnTheTestUrl()
        {
            LTDriver.WebDriver.Url = test_url;
        }

        [Then(@"select the first item")]
        public void ThenSelectTheFirstItem()
        {
            // Click on First Check box
            LTDriver.WebDriver.FindElement(By.Name("li1")).Click();

        }

        [Then(@"select the second item")]
        public void ThenSelectTheSecondItem()
        {
            // Click on Second Check box
            IWebElement secondCheckBox = LTDriver.WebDriver.FindElement(By.Name("li2"));
            secondCheckBox.Click();
        }

        [Then(@"find the text box to enter the new value")]
        public void ThenFindTheTextBoxToEnterTheNewValue()
        {
            // Enter Item name
            IWebElement textfield = LTDriver.WebDriver.FindElement(By.Id("sampletodotext"));
            textfield.SendKeys(itemName);
        }

        [Then(@"click the Submit button")]
        public void ThenClickTheSubmitButton()
        {
            // Click on Add button
            IWebElement addButton = LTDriver.WebDriver.FindElement(By.Id("addbutton"));
            addButton.Click();
        }

        [Then(@"verify whether the item is added to the list")]
        public void ThenVerifyWhetherTheItemIsAddedToTheList()
        {
            // Verified Added Item name
            IWebElement itemtext = LTDriver.WebDriver.FindElement(By.XPath("/html/body/div/div/div/form/input[1]"));
            String getText = itemtext.Text;

            // Check if the newly added item is present or not using
            // Condition constraint (Boolean)
            Assert.That((itemName.Contains(getText)), Is.True);

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);
        }
    }
}