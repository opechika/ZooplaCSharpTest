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


        public void EnterLocation(string location)
        {
            searchField.Clear();
            searchField.SendKeys(location);
        }


    }
}
