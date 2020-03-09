using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Specflow_FW.Context
{

    public class WebdriverContext
    {
        public ChromeDriver driver;

        public WebdriverContext()
        {
            driver = new ChromeDriver();
        }
    }

     /*This context class is used to store the webdriver instance so that it can be
     * shared across different binding classes.  The idea is that when a webdriver is called
     * during a scenario all infromation captured through each step is stored and 
     * re-accessed until the scenario is complete
     * 
     * Each class that uses the WebdriverContext will pass it into the parameter. A
     * private object of WebdriverContext type will be declared in the class and 
     * passed as the argument to the WebdriverContext
     * 
     * The driver will then be called used the argument followed by driver, e.g.
     * 
     * _webdriverContext.driver.findelement(by...
     */
}
