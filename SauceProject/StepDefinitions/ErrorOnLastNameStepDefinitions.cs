using SauceProject.Pages;
using System;
using TechTalk.SpecFlow;

namespace SauceProject.StepDefinitions
{
    [Binding]
    public class ErrorOnLastNameStepDefinitions
    {
        private readonly CheckoutPage _checkoutPage;

        public ErrorOnLastNameStepDefinitions(CheckoutPage checkoutPage)
        {
            _checkoutPage = checkoutPage;
        }

        [When(@"I see error message for last name missing")]
        public void WhenISeeErrorMessageForLastNameMissing()
        {
            _checkoutPage.Page.Url.Should().Be("https://www.saucedemo.com/checkout-step-one.html");
        }
    }
}
