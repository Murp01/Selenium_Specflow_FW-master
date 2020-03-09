using NUnit.Framework;
using Selenium_Specflow_FW.Context;
using Selenium_Specflow_FW.Page_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Selenium_Specflow_FW.Step_Defintions
{
    [Binding]
    public class Search_Results
    {
        private readonly SearchContext _searchContext;
        private readonly WebdriverContext _webdriverContext;
        private readonly PO_SearchResults _po_SearchResults;

        public Search_Results(SearchContext searchContext, WebdriverContext webdriverContext, 
            PO_SearchResults po_SearchResults)
        {
            this._webdriverContext = webdriverContext;
            this._searchContext = searchContext;
            this._po_SearchResults = po_SearchResults;
        }


        [Then(@"the search results will retrieve '(.*)'")]
        public void ThenTheSearchResultsWillRetrieve(string searchTerm)
        {
            _po_SearchResults.AssertSearchResults(searchTerm);
        }
    }
}
