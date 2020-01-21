using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooplaTestProject.Pages
{
    public class SearchResultPage : BasePage
    {
        public SearchResultPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.TagName, Using = "h1")]
        private IWebElement pageTitle;
        [FindsBy(How = How.CssSelector, Using = ".listing-results-price.text-price")]
        private IList<IWebElement> results;
        
        public void IsPageTitleDisplayedCorrectly(string property, string location)
        {
            string titleText = pageTitle.Text;
            Assert.IsTrue(titleText.Contains(property));
            Assert.IsTrue(titleText.Contains(location));
        }

        public void IsResultDisplayed()
        {
            Assert.IsTrue(results.Count > 0);
        }

        public ProductDetailsPage ClickOnAnyResult()
        {
            Random random = new Random();
            int ran = random.Next(0, results.Count - 1);
            results[ran].Click();
            return new ProductDetailsPage(_driver);
        }
    }
}
