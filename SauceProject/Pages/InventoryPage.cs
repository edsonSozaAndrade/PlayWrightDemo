using Microsoft.Playwright;
using PwSpecFlowDemoTest.PageObject;

namespace SauceProject.Pages
{
    public class InventoryPage : WebPage
    {
        public InventoryPage(IPage page) : base(page)
        {

        }

        #region Actions

        public async Task ClickOnBagPackItem()
        {
            await Page.RunAndWaitForNavigationAsync(async () =>
            {
                await Page.ClickAsync("id=item_4_img_link");
            });
        }

        public async Task ClickOnAddCart()
        {
            await Page.RunAndWaitForNavigationAsync(async () =>
            {
                await Page.ClickAsync("#add-to-cart-sauce-labs-backpack");
            });
        }

        public async Task ClickOnChartPage()
        {
            await Page.RunAndWaitForNavigationAsync(async () =>
            {
                await Page.ClickAsync("#shopping_cart_container");
            });
        }
        #endregion
    }
}

