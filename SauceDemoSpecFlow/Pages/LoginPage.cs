using Microsoft.Playwright;

namespace SauceDemoSpecFlow.Pages
{
    public class LoginPage : BasePageObject
    {
        public override string PagePath => "https://www.saucedemo.com";

        public LoginPage(IBrowser browser)
        {
            Browser = browser;
        }

        public override IPage Page { get; set; }

        public override IBrowser Browser { get; }

        #region Actions

        public Task FillWithValidUser() => Page.FillAsync("#user-name", "standard_user");

        public Task FillWithValidPassword() => Page.FillAsync("#password", "secret_sauce");

        public async Task ClickOnLoginPage()
        {
            await Page.RunAndWaitForNavigationAsync(async () =>
            {
                await Page.ClickAsync("#login-button");
            });
        }
        #endregion
    }
}
