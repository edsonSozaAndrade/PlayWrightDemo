using SauceProject.Pages;

namespace SauceProject.StepDefinitions
{
    [Binding]
    public class SauceLoginStepDefinitions
    {
        public readonly SauceLoginPage _loginPage;

        public SauceLoginStepDefinitions(SauceLoginPage loginPage)
        {
            _loginPage = loginPage;
        }

        [Given(@"I am in the Sauce Page")]
        public async Task GivenIAmInTheSaucePage()
        {
            await _loginPage.OpenLoginPage();
        }

        [When(@"I set username as ""([^""]*)""")]
        public async Task WhenISetUsernameAs(string p0)
        {
            await _loginPage.FillWithValidUser(p0);
        }

        [When(@"I set password as ""([^""]*)""")]
        public async Task WhenISetPasswordAs(string p0)
        {
            await _loginPage.FillWithValidPassword(p0);
        }

        [When(@"I click login button")]
        public async Task WhenIClickLoginButton()
        {
            await _loginPage.ClickOnLoginPage();
        }

        [Then(@"I should be in home page ""([^""]*)""")]
        public void ThenIShouldBeInHomePage(string p0)
        {
            _loginPage.Page.Url.Should().Be(p0);
        }
    }
}
