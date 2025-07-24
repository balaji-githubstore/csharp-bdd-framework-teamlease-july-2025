using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementBDD.Hooks
{
    [Binding]
    public class AutomationHooks
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void SetupScenario()
        {
            AutomationHooks.driver = new ChromeDriver();
            AutomationHooks.driver.Manage().Window.Maximize();
            AutomationHooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void TeaddownScenario()
        {
            if(driver != null)
            {
                driver.Dispose();
            }
        }
    }
}
