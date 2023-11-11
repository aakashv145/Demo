using EdAid.TestAutomation.Utilities;
using OpenQA.Selenium;
namespace EdAid.TestAutomation.StepDefinitions
{
    public class LamdaTestStep
    {
        public LambdaTestDriver LTDriver = null;

        public LamdaTestStep(ScenarioContext ScenarioContext)
        {
            LTDriver = (LambdaTestDriver)ScenarioContext["LTDriver"];
        }

        public void MarkTestAsFailedInLT(Exception e)
        {
            List<string> exceptions = new List<string>();
            exceptions.Add(e.Message);
            exceptions.Add(e.StackTrace);
            ((IJavaScriptExecutor)LTDriver.WebDriver).ExecuteScript("lambda-exceptions", exceptions);
            ((IJavaScriptExecutor)LTDriver.WebDriver).ExecuteScript("lambda-status=failed");
        }
    }
}
