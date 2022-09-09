using Microsoft.Playwright;

namespace SauceDemoSpecFlow
{
    public abstract class BasePageObject
    {
        protected readonly IPage Page;

        public BasePageObject(IPage page) => Page = page;
    }
}
