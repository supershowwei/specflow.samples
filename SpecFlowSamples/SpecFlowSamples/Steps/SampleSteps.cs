using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowSamples.Steps
{
    [Binding]
    public class SampleSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            Assert.IsTrue(true);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Assert.IsTrue(true);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.IsTrue(true);
        }
    }
}
