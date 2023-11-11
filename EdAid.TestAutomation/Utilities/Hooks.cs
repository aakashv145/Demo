namespace EdAid.TestAutomation.Utilities
{
    [Binding]
    public sealed class Hooks
    {

        private LambdaTestDriver LTDriver;
        private string[] tags;
        private ScenarioContext _scenarioContext;

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext ScenarioContext)
        {
            _scenarioContext = ScenarioContext;
            LTDriver = new LambdaTestDriver(ScenarioContext);
            ScenarioContext["LTDriver"] = LTDriver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            LTDriver.Cleanup();
        }
    }


    [Binding]
    public class Transforms
    {
        [StepArgumentTransformation]
        public BrowserType BrowserTypeTransform(string browserType)
        {
            // return the string converted into the required Enum
            switch (browserType)
            {
                case "Firefox":
                    return BrowserType.Firefox;
                case "Chrome":
                    return BrowserType.Chrome;
                case "InternetExplorer":
                    return BrowserType.InternetExplorer;
                case "Safari":
                    return BrowserType.Safari;
                default:
                    return BrowserType.Chrome;
            }
        }
    }

}
