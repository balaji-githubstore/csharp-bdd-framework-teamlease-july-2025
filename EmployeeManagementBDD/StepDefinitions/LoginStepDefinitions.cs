using EmployeeManagementBDD.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using System;

namespace EmployeeManagementBDD.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given("I have browser with OrangeHRM application")]
        public void GivenIHaveBrowserWithOrangeHRMApplication()
        {
            AutomationHooks.driver = new ChromeDriver();
            AutomationHooks.driver.Manage().Window.Maximize();
            AutomationHooks.driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            AutomationHooks.driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

        [When("I enter username as {string}")]
        public void WhenIEnterUsernameAs(string username)
        {
            AutomationHooks.driver.FindElement(By.Name("username")).SendKeys(username);
        }

        [When("I enter password as {string}")]
        public void WhenIEnterPasswordAs(string password)
        {
            AutomationHooks.driver.FindElement(By.Name("password")).SendKeys(password);
        }

        [When("I click on login")]
        public void WhenIClickOnLogin()
        {
            AutomationHooks.driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
        }

        [Then("I should access to portal with header as {string}")]
        public void ThenIShouldAccessToPortalWithHeaderAs(string expectedValue)
        {
            string actualValue = AutomationHooks.driver.FindElement(By.XPath("//p[contains(normalize-space(),'Work')]")).Text;
            Assert.That(actualValue, Is.EqualTo(expectedValue));
        }

        [Then("I should not get access with error as {string}")]
        public void ThenIShouldNotGetAccessWithErrorAs(string expectedError)
        {
            string actualValue = AutomationHooks.driver.FindElement(By.XPath("//p[contains(normalize-space(),'Invalid')]")).Text;
            Assert.That(actualValue.Contains("Invalid credential"), "Assertion on Invalid credentials");
        }
    }
}
