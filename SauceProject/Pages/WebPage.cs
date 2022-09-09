using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace PwSpecFlowDemoTest.PageObject
{
    public class WebPage
    {
        public readonly IPage Page;

        public WebPage (IPage page) => Page = page;

    }
}
