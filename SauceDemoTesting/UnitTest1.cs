using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace SauceDemoTesting
{
    [Parallelizable(ParallelScope.Self)]
    public class Tests : PageTest
    {
        public override BrowserNewContextOptions ContextOptions()
        {
            return new BrowserNewContextOptions()
            {
                ColorScheme = ColorScheme.Light,
                ViewportSize = new()
                {
                    Width = 1920,
                    Height = 1080
                },
                BaseURL = "https://github.com",
            };
        }

        [Test]
        public async Task ShowItemsOnHomePage()
        {
            await Login();
            await Expect(Page).ToHaveURLAsync(new Regex(".*inventory"));
            var backPackDetail = Page.Locator(@"#inventory_container > div > div:nth-child(1) > div.inventory_item_description");
            await Expect(backPackDetail).ToContainTextAsync("29.99"); 
        }


        [Test]
        public async Task ShowItemsOnCartPage()
        {
            await Login();
            await Expect(Page).ToHaveURLAsync(new Regex(".*inventory"));
            await Page.Locator("id=item_4_img_link").ClickAsync(); 
            await Page.Locator("#add-to-cart-sauce-labs-backpack").ClickAsync(); 
            await Page.Locator("#shopping_cart_container").ClickAsync();
            var cartDetail = Page.Locator(@"#cart_contents_container > div > div.cart_list");
            await Expect(cartDetail).ToContainTextAsync("29.99");
        }

        [Test]
        public async Task BuyProduct()
        {
            await Login();
            await Expect(Page).ToHaveURLAsync(new Regex(".*inventory"));
            await Page.Locator("id=item_4_img_link").ClickAsync();
            await Page.Locator("#add-to-cart-sauce-labs-backpack").ClickAsync();
            await Page.Locator("#shopping_cart_container").ClickAsync();
            await Page.Locator("#checkout").ClickAsync();
            await Page.Locator("id=first-name").FillAsync("Edson");
            await Page.Locator("id=last-name").FillAsync("Soza");
            await Page.Locator("id=postal-code").FillAsync("12345");
            await Page.Locator("id=continue").ClickAsync();
            await Page.Locator("id=finish").ClickAsync();
            var divThankYou = Page.Locator(@"#checkout_complete_container");
            await Expect(divThankYou).ToContainTextAsync("THANK YOU FOR YOUR ORDER");
        }

        [Test]
        public async Task ErrorWithFirstName()
        {
            await Login();
            await Expect(Page).ToHaveURLAsync(new Regex(".*inventory"));
            await Page.Locator("id=item_4_img_link").ClickAsync();
            await Page.Locator("#add-to-cart-sauce-labs-backpack").ClickAsync();
            await Page.Locator("#shopping_cart_container").ClickAsync();
            await Page.Locator("#checkout").ClickAsync();
            await Page.Locator("id=continue").ClickAsync();
            var errorDiv = Page.Locator(@"#checkout_info_container > div > form > div.checkout_info > div.error-message-container.error");
            await Expect(errorDiv).ToContainTextAsync("Error: First Name is required");
        }

        [Test]
        public async Task ErrorWithLastName()
        {
            await Login();
            await Expect(Page).ToHaveURLAsync(new Regex(".*inventory"));
            await Page.Locator("id=item_4_img_link").ClickAsync();
            await Page.Locator("#add-to-cart-sauce-labs-backpack").ClickAsync();
            await Page.Locator("#shopping_cart_container").ClickAsync();
            await Page.Locator("#checkout").ClickAsync();
            await Page.Locator("id=first-name").FillAsync("Edson");
            await Page.Locator("id=continue").ClickAsync();
            var errorDiv = Page.Locator(@"#checkout_info_container > div > form > div.checkout_info > div.error-message-container.error");
            await Expect(errorDiv).ToContainTextAsync("Error: Last Name is required");
        }

        [Test]
        public async Task ErrorWithZipCode()
        {
            await Login();
            await Expect(Page).ToHaveURLAsync(new Regex(".*inventory"));
            await Page.Locator("id=item_4_img_link").ClickAsync();
            await Page.Locator("#add-to-cart-sauce-labs-backpack").ClickAsync();
            await Page.Locator("#shopping_cart_container").ClickAsync();
            await Page.Locator("#checkout").ClickAsync();
            await Page.Locator("id=first-name").FillAsync("Edson");
            await Page.Locator("id=last-name").FillAsync("Soza");
            await Page.Locator("id=continue").ClickAsync();
            var errorDiv = Page.Locator(@"#checkout_info_container > div > form > div.checkout_info > div.error-message-container.error");
            await Expect(errorDiv).ToContainTextAsync("Error: Postal Code is required");
        }

        private async Task Login() {
            await Page.GotoAsync("https://www.saucedemo.com");
            await Page.Locator("#user-name").FillAsync("standard_user");
            await Page.Locator("#password").FillAsync("secret_sauce");
            await Page.Locator("#login-button").ClickAsync();
        }
    }    
}