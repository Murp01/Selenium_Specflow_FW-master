using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Selenium_Specflow_FW.Step_Defintions
{
    [Binding]
    public sealed class SearchHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("In Method Before test run!!");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("In Method After test run!!");
        }


        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("In Method Before Feature!");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("In Method After Feature!");
        }



        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("In Method Before Scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("In Method After Scenario");
        }
    }
}
