using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium_Specflow_FW.Context;
using Selenium_Specflow_FW.Page_Objects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Selenium_Specflow_FW.Step_Defintions
{
    [Binding]
    public class HomePage : IDisposable
    {
        private readonly SearchContext _searchContext;
        private readonly WebdriverContext _webdriverContext;
        private readonly PO_HomePage _po_Homepage;

        public HomePage(SearchContext searchContext, WebdriverContext webdriverContext, 
            PO_HomePage po_Homepage)
        {
            this._webdriverContext = webdriverContext;
            this._searchContext = searchContext;
            this._po_Homepage = po_Homepage;
        }


        [Given(@"I am on the Morrisons home page")]
        public void GivenIAmOnTheMorrisonsHomePage()
        {
            _webdriverContext.driver.Navigate().GoToUrl("https://groceries.morrisons.com/webshop/startWebshop.do");
            Assert.IsTrue(_webdriverContext.driver.Title.ToLower().Contains("morrisons"));
        }
        
        [Given(@"I have type '(.*)' into the site search bar")]
        public void GivenIHaveTypeIntoTheSiteSearchBar(string searchTerm)
        {
            _searchContext.searchTerm = searchTerm.ToLower();
            var searchInputBox = _webdriverContext.driver.FindElementById("findText");
            var wait = new WebDriverWait(_webdriverContext.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("findText")));
            _webdriverContext.driver.FindElementById("findText").SendKeys(_searchContext.searchTerm);
        }
        
        [When(@"I press the Go button on the site search bar")]
        public void WhenIPressTheGoButtonOnTheSiteSearchBar()
        {
            _po_Homepage.ClickOnGoButton();
        }
        

        public void Dispose()
        {
            if (_webdriverContext != null)
            {
                _webdriverContext.driver.Dispose();
                _webdriverContext.driver = null;
            }
        }

    }
}
