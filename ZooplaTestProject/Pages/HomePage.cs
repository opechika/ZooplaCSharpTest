using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooplaTestProject.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "search-input-location")]
        private IWebElement searchField;
        [FindsBy(How = How.Name, Using = "price_min")]
        private IWebElement minPrice;
        [FindsBy(How = How.CssSelector, Using = ".button.button--primary")]
        private IWebElement submitButton;
        

        public void EnterLocation(string location)
        {
            searchField.Clear();
            searchField.SendKeys(location);
        }

        public void SelectMinimumPrice(string miniPrice)
        {
            SelectByText(minPrice, miniPrice);
        }


        public SearchResultPage ClickOnSearchButton()
        {
            submitButton.Click();
            return new SearchResultPage(_driver);
        }



    }
}
