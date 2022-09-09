using SauceProject.Pages;
using System;
using TechTalk.SpecFlow;

namespace SauceProject.StepDefinitions
{
    [Binding]
    public class ErrorsOnCheckoutStepDefinitions
    {
        private readonly CheckoutPage _checkoutPage;

        public ErrorsOnCheckoutStepDefinitions(CheckoutPage checkoutPage)
        {
            _checkoutPage = checkoutPage;
        }
        [When(@"I see error message for first name missing")]
        public void WhenISeeErrorMessageForFirstNameMissing()
        {
            _checkoutPage.Page.Url.Should().Be("https://www.saucedemo.com/checkout-step-one.html");
        }
    }
}
