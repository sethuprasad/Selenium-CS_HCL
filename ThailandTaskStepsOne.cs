using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SpecfflowDemoi
{
    [Binding]
    public class ThailandTaskStepsOne
    {
     //   string url;
        IWebDriver TLdriver = new ChromeDriver();
        [Given(@"Navigate to the TaiLnad Home Page '(.*)'")]
        public void GivenNavigateToTheTaiLnadHomePage(string TLHomePage)
        {
           // this.url = TLHomePage;
            
            TLdriver.Navigate().GoToUrl(TLHomePage);
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"Click Attractiond Down the Page")]
        public void GivenClickAttractiondDownThePage()
        {
            // ScenarioContext.Current.Pending();
            IWebElement attractions = TLdriver.FindElement(By.XPath("(//a[text()='Attractions'])[3]"));
            TLdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2.0);
            attractions.Click();

        }
        
        [When(@"Attaractions Page opens")]
        public void WhenAttaractionsPageOpens()
        {
            TLdriver.Manage().Window.Maximize();
            TLdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2.0);
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"hover over each of the Moresights and Attractions")]
        public void ThenHoverOverEachOfTheMoresightsAndAttractions()
        {
            //Actions faction = new Actions(TLdriver);
            //for(int i=1;i<=5;i++)
            //{
            //    IWebElement family = TLdriver.FindElement(By.XPath("/html/body/article/article/div[2]/div[1]/div/div/div["+i+"]/a/img"));
            //    TLdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4.0);
            //    faction.MoveToElement(family).Perform();
            //}

            // ScenarioContext.Current.Pending();
        }
        
        [Then(@"The following attractions will be displayed")]
        public void ThenTheFollowingAttractionsWillBeDisplayed()
        {
            Actions faction = new Actions(TLdriver);
            for (int i = 1; i <= 5; i++)
            {
                IWebElement family = TLdriver.FindElement(By.XPath("/html/body/article/article/div[2]/div[1]/div/div/div[" + i + "]/a/img"));
                TLdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4.0);

                faction.MoveToElement(family).Perform();
                faction.SendKeys(Keys.Control + "t").Click().Build().Perform();

                TLdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4.0);

                TLdriver.Navigate().GoToUrl("https://www.tourismthailand.org/Attraction");


            }
            //   ScenarioContext.Current.Pending();
        }
        
        [Then(@"Each attraction Page will be Displayed\.")]
        public void ThenEachAttractionPageWillBeDisplayed_()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
