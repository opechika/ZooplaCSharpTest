﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ZooplaTestProject.Pages;

namespace ZooplaTestProject.StepDefinitions
{
    [Binding]
    public sealed class ForSaleSearchStep : BasePage
    {
        HomePage homePage = new HomePage(_driver);
        SearchResultPage searchResultPage = new SearchResultPage(_driver);
        ProductDetailsPage productDetailsPage = new ProductDetailsPage(_driver);

        [Given(@"I navigate to zoopla homepage")]
        public void GivenINavigateToZooplaHomepage()
        {
            homePage.LaunchUrl();
        }

        [When(@"I enter a ""(.*)"" in the search text box")]
        public void WhenIEnterAInTheSearchTextBox(string location)
        {
            homePage.EnterLocation(location);
        }

        [When(@"I select ""(.*)"" from Min price dropdown")]
        public void WhenISelectFromMinPriceDropdown(string minPrice)
        {
            homePage.SelectMinimumPrice(minPrice);
        }

        [When(@"I select ""(.*)"" from Max price dropdown")]
        public void WhenISelectFromMaxPriceDropdown(string p0)
        {

        }

        [When(@"I select ""(.*)"" from Property type dropdown")]
        public void WhenISelectFromPropertyTypeDropdown(string p0)
        {

        }

        [When(@"I select ""(.*)"" from Bedrooms dropdown")]
        public void WhenISelectFromBedroomsDropdown(Decimal p0)
        {

        }

        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            searchResultPage = homePage.ClickOnSearchButton();
        }

        [Then(@"a list of ""(.*)"" in ""(.*)"" are displayed")]
        public void ThenAListOfInAreDisplayed(string property, string location)
        {
            searchResultPage.IsPageTitleDisplayedCorrectly(property, location);
            searchResultPage.IsResultDisplayed();
        }

        [Then(@"I click on any of the result to view more detail")]
        public void ThenIClickOnAnyOfTheResultToViewMoreDetail()
        {
            productDetailsPage = searchResultPage.ClickOnAnyResult();
        }

    }
}
