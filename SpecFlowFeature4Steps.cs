using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecfflowDemoi
{
    [Binding]
    public class SpecFlowFeature4Steps
    {
        IWebDriver driver2 = new ChromeDriver();
        IWebElement ele;
        [Given(@"I have Navigated to '(.*)'")]
        public void GivenIHaveNavigatedTo(string p0)
        {
            driver2.Navigate().GoToUrl(p0);
            //ScenarioContext.Current.Pending();
        }

        [Given(@"entered '(.*)' into the Search Box")]
        public void GivenEnteredIntoTheSearchBox(string p0)
        {
           // ScenarioContext.Current.Pending();
            ele = driver2.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[1]/div/div[1]/input"));
            ele.SendKeys(p0);
        }

      
        [Then(@"I Search the text")]
        public void ThenISearchTheText()
        {
            //ScenarioContext.Current.Pending();
            ele = driver2.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[1]/div/div[1]/input"));
            ele.SendKeys("yes");
        }

        [When(@"I enter")]
        public void WhenIEnter()
        {
            //ScenarioContext.Current.Pending();
            ele = driver2.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[1]/div/div[1]/input"));
            ele.SendKeys("yes");
        }

        [Then(@"the result should be displayes on the screenmk")]
        public void ThenTheResultShouldBeDisplayesOnTheScreenmk()
        {
            ///ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result will be displayed")]
        public void ThenTheResultWillBeDisplayed()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
