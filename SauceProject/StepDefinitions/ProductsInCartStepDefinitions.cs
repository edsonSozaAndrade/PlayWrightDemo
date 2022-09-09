using SauceProject.Pages;
using System;
using TechTalk.SpecFlow;

namespace SauceProject.StepDefinitions
{
    [Binding]
    public class ProductsInCartStepDefinitions
    {
        public readonly SauceLoginPage _loginPage;
        public readonly InventoryPage _inventoryPage;

        public ProductsInCartStepDefinitions(SauceLoginPage loginPage, InventoryPage inventoryPage)
        {
            _loginPage = loginPage;
            _inventoryPage = inventoryPage;
        }

        [When(@"I Click on BagPack Item")]
        public async Task WhenIClickOnBagPackItem()
        {
            await _inventoryPage.ClickOnBagPackItem();
        }

        [When(@"I Click on AddCart")]
        public async void WhenIClickOnAddCart()
        {
            await _inventoryPage.ClickOnAddCart();
        }


        [When(@"I click on Cart Button")]
        public async Task WhenIClickOnCartButton()
        {
            await _inventoryPage.ClickOnChartPage();
        }

        [Then(@"I should be in cart page ""([^""]*)""")]
        public void ThenIShouldBeInCartPage(string p0)
        {
            _inventoryPage.Page.Url.Should().Be(p0);
        }

        [Then(@"Should be a bagpack item with price ""([^""]*)""")]
        public void ThenShouldBeABagpackItemWithPrice(string p0)
        {
            return;
        }

    }
}
