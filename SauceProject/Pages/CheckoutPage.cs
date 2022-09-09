using Microsoft.Playwright;
using PwSpecFlowDemoTest.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceProject.Pages
{
    public class CheckoutPage : WebPage
    {
        public CheckoutPage(IPage page) : base(page)
        {

        }

        #region Actions

        public async Task FillFirstName(string firstName) => await Page.FillAsync("id=first-name", firstName);
        public async Task FillLastName(string lastName) => await Page.FillAsync("id=last-name", lastName);
        public async Task FillZipCode(string zipCode) => await Page.FillAsync("id=postal-code", zipCode);

        public async Task ClickOnContinueButton()
        {
            await Page.RunAndWaitForNavigationAsync(async () =>
            {
                await Page.ClickAsync("id=continue");
            });
        }
        public async Task ClickOnFinishButton()
        {
            await Page.RunAndWaitForNavigationAsync(async () =>
            {
                await Page.ClickAsync("id=finish");
            });
        }

        public async Task<string> CheckErrorOnFirstName()
        {
            var innerText = string.Empty;
            await Page.RunAndWaitForNavigationAsync(async () =>
            {
                var locator = Page.Locator(@"#checkout_info_container > div > form > div.checkout_info > div.error-message-container.error");
                innerText = await locator.InnerTextAsync();
            });
            return innerText;
        }
        #endregion
    }
}
