using NUnit.Framework;
using Selenium_Specflow_FW.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Specflow_FW.Page_Objects
{
    public class PO_SearchResults
    {
        public String searchTerm;
        private readonly SearchContext _searchContext;
        private readonly WebdriverContext _webdriverContext;

        public PO_SearchResults(SearchContext searchContext, WebdriverContext webdriverContext)
        {
            this._webdriverContext = webdriverContext;
            this._searchContext = searchContext;
        }


        public void AssertSearchResults(string searchTerm)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(_webdriverContext.driver.Url.ToLower().Contains(_searchContext.searchTerm));
            Assert.IsTrue(_webdriverContext.driver.Title.ToLower().Contains(_searchContext.searchTerm));
        }
    }
}
