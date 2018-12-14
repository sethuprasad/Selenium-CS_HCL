using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecfflowDemoi
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        IWebDriver driver = new ChromeDriver();
        IWebElement ele;
       [Given(@"I have entered '(.*)' into address bar")]
        public void GivenIHaveEnteredIntoAddressBar(string p0)
        {
            driver.Navigate().GoToUrl(p0);
        }
        
        [Given(@"I have entered '(.*)' into the Search Box")]
        public void GivenIHaveEnteredIntoTheSearchBox(string val)
        {
            ele = driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[1]/div/div[1]/input"));
            ele.SendKeys(val);
        }
        
        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
            ele.SendKeys(Keys.Enter);
            //ScenarioContext.Current.Pending();
        }
    }
}
