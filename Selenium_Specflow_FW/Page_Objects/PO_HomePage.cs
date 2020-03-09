using Selenium_Specflow_FW.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Specflow_FW.Page_Objects
{
    public class PO_HomePage
    {
        public String searchTerm;
        private readonly SearchContext _searchContext;
        private readonly WebdriverContext _webdriverContext;

        public PO_HomePage(SearchContext searchContext, WebdriverContext webdriverContext)
        {
            this._webdriverContext = webdriverContext;
            this._searchContext = searchContext;
        }

        public void ClickOnGoButton()
        {
            var searchButton = _webdriverContext.driver.FindElementById("findButton");
            searchButton.Click();
        }
    }
}
