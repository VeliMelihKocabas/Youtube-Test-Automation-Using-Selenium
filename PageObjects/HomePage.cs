using OpenQA.Selenium;




namespace SpecFlowProject2.PageObjects
{
    public class HomePage
    {

        // Sayfa üzerindeki elementler (örneğin, YouTube arama kutusu)
        private IWebElement SearchBox => driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[4]/div[2]/ytd-searchbox/form/div[1]/div[1]/input"));
        private IWebElement SearchButton => driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[4]/div[2]/ytd-searchbox/button"));


        private IWebDriver driver;
        // Constructor
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        
        // Verilen IWebElement'in sayfada olup olmadığını kontrol eden method
        public bool IsElementPresent(IWebElement element)
        {
            try
            {
                // Element görünürse true döner
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                // Eğer element bulunamazsa false döner
                return false;
            }
        }

        // Arama işlemi
        public void SearchAndEnter(string searchTerm)
        {
            SearchBox.Click();
            SearchBox.SendKeys(searchTerm);
            SearchButton.Click();
        }
    }
}
