
using EmployeeManagementBDD.Hooks;
using OpenQA.Selenium;

namespace EmployeeManagementBDD.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions 
    {

        private readonly IWebDriver driver;
        public EmployeeStepDefinitions(AutomationHooks hooks)
        {
            driver = hooks.driver;
        }


        [When("I click on PIM menu")]
        public void WhenIClickOnPIMMenu()
        {
            driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
        }

        [When("I click on Add Employee menu")]
        public void WhenIClickOnAddEmployeeMenu()
        {
            driver.FindElement(By.LinkText("Add Employee")).Click();
        }

        [When("I fill the employee form")]
        public void WhenIFillTheEmployeeForm(DataTable dataTable)
        {
            Console.WriteLine(dataTable);
            //FILL THE FIRSTNAME, MIDDLENAME, LASTNAME
            Console.WriteLine(dataTable.RowCount);

            Console.WriteLine(dataTable.Rows[0][0]);
            Console.WriteLine(dataTable.Rows[0][1]);
            Console.WriteLine(dataTable.Rows[0][2]);

            Console.WriteLine(dataTable.Rows[0]["firstName"]);
            Console.WriteLine(dataTable.Rows[0]["middleName"]);
            Console.WriteLine(dataTable.Rows[0]["lastName"]);

            driver.FindElement(By.Name("firstName")).SendKeys(dataTable.Rows[0]["firstName"]);
            driver.FindElement(By.Name("middleName")).SendKeys(dataTable.Rows[0]["middleName"]);
            driver.FindElement(By.Name("lastName")).SendKeys(dataTable.Rows[0]["lastName"]);
        }

        [When("I click on save employee")]
        public void WhenIClickOnSaveEmployee()
        {
            
        }

        [Then("I should get the profile name as {string}")]
        public void ThenIShouldGetTheProfileNameAs(string expectedProfileName)
        {
            
        }

        [Then("I should get all field with filled data")]
        public void ThenIShouldGetAllFieldWithFilledData()
        {
            //use same datatable and verify it 
        }
    }
}
