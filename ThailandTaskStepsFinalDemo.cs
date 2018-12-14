using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SpecfflowDemoi.POM_SF;
namespace SpecfflowDemoi
{
    [Binding]
    public class ThailandTaskStepsFinalDemo
    {
        SFTrial POM_Obj;
        //IWebDriver TLdriver = new ChromeDriver();
        [Given(@"I have Navigated to the TaiLand Home Page '(.*)'")]
        public void GivenIHaveNavigatedToTheTaiLandHomePage(string TLHomePage)
        {
            POM_Obj = new SFTrial(TLHomePage);
            POM_Obj.Navigate();
            //TLdriver.Navigate().GoToUrl(TLHomePage);
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I Clicked on Attractions")]
        public void GivenIClickedOnAttractions()
        {
            //IWebElement attractions = TLdriver.FindElement(By.XPath("(//a[text()='Attractions'])[3]"));
            //TLdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2.0);
            //attractions.Click();
            POM_Obj.Attractions_Page();
            // ScenarioContext.Current.Pending();
        }

        [When(@"I moved to Sights and Attractions Section")]
        public void WhenIMovedToSightsAndAttractionsSection()
        {
            //ScenarioContext.Current.Pending();

            // TLdriver.Manage().Window.Maximize();
            //TLdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2.0);
            POM_Obj.Maximize_window();
            POM_Obj.Implicit_wait(2.0);

        }

        [Then(@"I hovered on Moresights and Attractions")]
        public void ThenIHoveredOnMoresightsAndAttractions()
        {
            // ScenarioContext.Current.Pending();
            //////  IWebDriver TLdriver = SFTrial.driveTo;
            //Actions faction = new Actions(TLdriver);

            POM_Obj.Scroll_to_Element();
            //for (int i = 1; i <= 5; i++)
            //{
            //    IWebElement family = TLdriver.FindElement(By.XPath("/html/body/article/article/div[2]/div[1]/div/div/div[" + i + "]/a/img"));
            //    TLdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);

            //    faction.MoveToElement(family).Perform();
            //    faction.SendKeys(Keys.Control + "t").Click().Build().Perform();
            //}
        }

        [Then(@"The following attractions will be displayed in new tabs")]
        public void ThenTheFollowingAttractionsWillBeDisplayedInNewTabs()
        {
            POM_Obj.View_page();
            //Actions faction = new Actions(TLdriver);
            //int count = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    IWebElement family = TLdriver.FindElement(By.XPath("/html/body/article/article/div[2]/div[1]/div/div/div[" + i + "]/a/img"));
            //    TLdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);
            //    try
            //    {
            //        faction.MoveToElement(family).Perform();
            //        faction.SendKeys(Keys.Control + "t").Click().Build().Perform();

            //    }
            //    catch
            //    {
            //        faction.MoveToElement(family).Perform();
            //        faction.SendKeys(Keys.Control + "t").Click().Build().Perform();
            //        if (count > 3)
            //        {
            //            break;
            //        }
            //        else
            //            count++;
            //    }
            //    TLdriver.Navigate().GoToUrl("https://www.tourismthailand.org/Attraction");

            //    TLdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4.0);

            //    //ScenarioContext.Current.Pending();
            //}
        }
    }
}
