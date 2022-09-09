using Microsoft.Playwright;
using PwSpecFlowDemoTest.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceProject.Pages
{
    public class CartPage : WebPage
    {
        public CartPage(IPage page) : base(page)
        {

        }

        #region Actions

        public async Task ClickOnCheckoutPage()
        {
            await Page.RunAndWaitForNavigationAsync(async () =>
            {
                await Page.ClickAsync("#checkout");
            });
        }
        #endregion
    }
}

