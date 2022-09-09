using SauceProject.Pages;
using System;
using TechTalk.SpecFlow;

namespace SauceProject.StepDefinitions
{
    [Binding]
    public class BuyProductStepDefinitions
    {
        private readonly CartPage _cartPage;
        private readonly CheckoutPage _checkoutPage;
        private readonly SauceLoginPage _loginPage;
        private readonly InventoryPage _inventoryPage;

        public BuyProductStepDefinitions(SauceLoginPage loginPage, InventoryPage inventoryPage, CartPage cartPage, CheckoutPage checkoutPage)
        {
            _loginPage = loginPage;
            _inventoryPage = inventoryPage;
            _cartPage = cartPage;
            _checkoutPage = checkoutPage;
        }

        [When(@"I clik on checkout button")]
        public async Task WhenIClikOnCheckoutButton()
        {
            await _cartPage.ClickOnCheckoutPage();
        }

        [When(@"I set first name as ""([^""]*)""")]
        public async Task WhenISetFirstNameAs(string edson)
        {
            await _checkoutPage.FillFirstName(edson);
        }

        [When(@"I set last name as ""([^""]*)""")]
        public async void WhenISetLastNameAs(string soza)
        {
            await _checkoutPage.FillLastName(soza);
        }

        [When(@"I set Zip code as ""([^""]*)""")]
        public async void WhenISetZipCodeAs(string p0)
        {
            await _checkoutPage.FillZipCode(p0);
        }

        [When(@"I click on Continue")]
        public async void WhenIClickOnContinue()
        {
            await _checkoutPage.ClickOnContinueButton();
        }

        [When(@"I click on finish Button")]
        public async void WhenIClickOnFinishButton()
        {
            await _checkoutPage.ClickOnFinishButton();
        }

    }
}
