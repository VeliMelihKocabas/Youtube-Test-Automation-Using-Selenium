using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject2.PageObjects;


namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class YoutubeSearchFeatureStepDefinitions
    {
        private IWebElement ThreeeLineButton => driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[4]/div[1]/yt-icon-button[2]/button/yt-icon/span/div"));
        private IWebElement HomePageButton => driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/tp-yt-app-drawer/div[2]/div/div[2]/div[2]/ytd-guide-renderer/div[1]/ytd-guide-section-renderer[1]/div/ytd-guide-entry-renderer[1]/a/tp-yt-paper-item/yt-formatted-string"));
        private IWebElement ShortsButton => driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/tp-yt-app-drawer/div[2]/div/div[2]/div[2]/ytd-guide-renderer/div[1]/ytd-guide-section-renderer[1]/div/ytd-guide-entry-renderer[2]/a/tp-yt-paper-item/yt-formatted-string"));
        private IWebElement SubscriptionsButton => driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/tp-yt-app-drawer/div[2]/div/div[2]/div[2]/ytd-guide-renderer/div[1]/ytd-guide-section-renderer[1]/div/ytd-guide-entry-renderer[3]/a/tp-yt-paper-item/yt-formatted-string"));
        private IWebElement YouButton => driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/tp-yt-app-drawer/div[2]/div/div[2]/div[2]/ytd-guide-renderer/div[1]/ytd-guide-section-renderer[2]/div/ytd-guide-entry-renderer[1]/a/tp-yt-paper-item/yt-formatted-string"));
        private IWebElement HistoryButton => driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/tp-yt-app-drawer/div[2]/div/div[2]/div[2]/ytd-guide-renderer/div[1]/ytd-guide-section-renderer[2]/div/ytd-guide-entry-renderer[2]/a/tp-yt-paper-item/yt-formatted-string"));

        private IWebDriver driver;
        private HomePage homePage;

        [Given(@"User open the browser")]
        public void GivenUserOpenTheBrowser()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);
        }

        [When(@"User enter the url ""([^""]*)""")]
        public void WhenUserEnterTheUrl(string specificUrl)
        {
            driver.Navigate().GoToUrl(specificUrl);
            Thread.Sleep(1000);
        }

        // Kullanýcý arama kutusuna týklar ve arama terimini girer
        [Then(@"User click search area and search for the ""(.*)"" then click search button\.")]
        public void ThenUserClickSearchAreaAndSearchForThe(string searchTerm)
        {
            homePage.SearchAndEnter(searchTerm);
            Thread.Sleep(1000);
        }

        [Then(@"User click x button in the search textbox\.")]
        public void ThenUserClickXButtonInTheSearchTextbox()
        {
            driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[4]/div[2]/ytd-searchbox/form/div[1]/div[2]/ytd-button-renderer/yt-button-shape/button")).Click();
            Thread.Sleep(1000);
            driver.Quit();
        }

        [Then(@"User clicks three line menü button.")]
        public void ThenUserClicksThreeLineMenuButton()
        {
            Thread.Sleep(1000);
            ThreeeLineButton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"User should see these buttons; MainPage, Shorts, Subscriptions, You, History.")]
        public void ThenUserShouldSeeTheseButtons()
        {
            homePage.IsElementPresent(HomePageButton);
            homePage.IsElementPresent(ShortsButton);
            homePage.IsElementPresent(SubscriptionsButton);
            homePage.IsElementPresent(YouButton);
            homePage.IsElementPresent(HistoryButton);
            Thread.Sleep(1000);
            driver.Quit();
        }

    }
}
