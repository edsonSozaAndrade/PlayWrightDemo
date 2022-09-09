using Microsoft.Playwright;
using PwSpecFlowDemoTest.PageObject;

namespace SauceProject.Pages
{
    public class SauceLoginPage : WebPage
    {
        public SauceLoginPage(IPage page) : base(page)
        {

        }

        public async Task OpenLoginPage()
        {
            await Page.GotoAsync("https://www.saucedemo.com");
        }

        public async Task FillWithValidUser(string user) => await Page.FillAsync("#user-name", user);

        public async Task FillWithValidPassword(string password) => await Page.FillAsync("#password", password);

        public async Task ClickOnLoginPage()
        {
            await Page.RunAndWaitForNavigationAsync(async () =>
            {
                await Page.ClickAsync("#login-button");
            });
        }
    }
}