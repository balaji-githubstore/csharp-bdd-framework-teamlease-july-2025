using EmployeeManagementBDD.Hooks;
using EmployeeManagementBDD.Pages;
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
        private readonly LoginPage _loginPage;
        private readonly DashboardPage _dashboardPage;
        private readonly ScenarioContext _scenarioContext;
        public LoginStepDefinitions(LoginPage loginPage, DashboardPage dashboardPage, ScenarioContext scenarioContext)
        {
            this._loginPage = loginPage;
            this._dashboardPage = dashboardPage;
            _scenarioContext = scenarioContext;
        }

        [Given("I have browser with OrangeHRM application")]
        [Given("I have opened OrangeHRM application")]
        public void GivenIHaveBrowserWithOrangeHRMApplication()
        {
            _loginPage.NavigateToUrl();
        }

        [When("I enter username as {string}")]
        public void WhenIEnterUsernameAs(string username)
        {
            _scenarioContext.Add("username", username);
            _loginPage.EnterUsername(username);
        }

        [When("I enter password as {string}")]
        public void WhenIEnterPasswordAs(string password)
        {
            _loginPage.EnterPassword(password);
        }

        [When("I click on login")]
        public void WhenIClickOnLogin()
        {
            _loginPage.ClickOnLogin();
        }

        [Then("I should access to portal with header as {string}")]
        public void ThenIShouldAccessToPortalWithHeaderAs(string expectedValue)
        {
            string actualValue = _dashboardPage.GetTimeAtWorkHeader();
            Assert.That(actualValue, Is.EqualTo(expectedValue));
        }

        [Then("I should not get access with error as {string}")]
        public void ThenIShouldNotGetAccessWithErrorAs(string expectedError)
        {
            Assert.That(_loginPage.GetInvalidErrorMessage().Contains("Invalid credential"), "Assertion on Invalid credentials");
        }
    }
}
