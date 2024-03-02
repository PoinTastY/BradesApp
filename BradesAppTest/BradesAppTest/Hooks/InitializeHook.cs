using BradesAppTest.Drivers;

namespace BradesAppTest.Hooks
{
    [Binding]
    class InitializeHook
    {
        private TestingDriver driver;

        [BeforeScenario]
        public void Initialize()
        {
            driver = new(ScenarioContext.Current);
            //context injection
            ScenarioContext.Current["driver"] = driver;


        }

        //[AfterScenario]
        //public void AfterScenario()
        //{
        //    driver.Cleanup();
        //}
    }
}
