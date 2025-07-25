
using EmployeeManagementBDD.Hooks;
using EmployeeManagementBDD.Pages;
using EmployeeManagementBDD.Support;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EmployeeManagementBDD.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions 
    {
        private readonly MainPage _mainPage;
        private readonly PIMPage _pimPage;
        private readonly AddEmployeePage _addEmployeePage;
        private readonly PersonalDetailsPage _personalDetailsPage;
        private readonly ScenarioContext _scenarioContext;
        public EmployeeStepDefinitions(MainPage mainPage, PIMPage pimPage, AddEmployeePage addEmployeePage, PersonalDetailsPage personalDetailsPage,ScenarioContext scenarioContext)
        {
            _mainPage= mainPage;
            _pimPage= pimPage;
            _addEmployeePage= addEmployeePage;
            _personalDetailsPage= personalDetailsPage;
            _scenarioContext = scenarioContext;
        }

        [When("I click on PIM menu")]
        public void WhenIClickOnPIMMenu()
        {
            _mainPage.ClickOnPIMMenu();
        }

        [When("I click on Add Employee menu")]
        public void WhenIClickOnAddEmployeeMenu()
        {
            _pimPage.ClickOnAddEmployee();
        }

        [When("I fill the employee form")]
        public void WhenIFillTheEmployeeForm(DataTable dataTable)
        {
            EmployeeModel empModel=dataTable.CreateInstance<EmployeeModel>();

            //  var emps= dataTable.CreateSet<EmployeeModel>();

            //dynamic dynEmp = dataTable.CreateInstance<object>();
            //Console.WriteLine(dynEmp.firstName);

            _scenarioContext.Add("employeeDt", dataTable);
           
            //Console.WriteLine(dataTable);
            ////FILL THE FIRSTNAME, MIDDLENAME, LASTNAME
            //Console.WriteLine(dataTable.RowCount);

            //Console.WriteLine(dataTable.Rows[0][0]);
            //Console.WriteLine(dataTable.Rows[0][1]);
            //Console.WriteLine(dataTable.Rows[0][2]);

            //Console.WriteLine(dataTable.Rows[0]["firstName"]);
            //Console.WriteLine(dataTable.Rows[0]["middleName"]);
            //Console.WriteLine(dataTable.Rows[0]["lastName"]);

            //driver.FindElement(By.Name("firstName")).SendKeys(dataTable.Rows[0]["firstName"]);
            //driver.FindElement(By.Name("middleName")).SendKeys(dataTable.Rows[0]["middleName"]);
            //driver.FindElement(By.Name("lastName")).SendKeys(dataTable.Rows[0]["lastName"]);

            //_addEmployeePage.FillEmployeeDetails(dataTable.Rows[0]["firstName"],
            //    dataTable.Rows[0]["middleName"], dataTable.Rows[0]["lastName"]);

            _addEmployeePage.FillEmployeeDetails(empModel.FirstName, empModel.MiddleName, empModel.LastName);
        }

        [When("I click on save employee")]
        public void WhenIClickOnSaveEmployee()
        {
            _addEmployeePage.ClickOnSave();
        }

        [Then("I should get the profile name as {string}")]
        public void ThenIShouldGetTheProfileNameAs(string expectedProfileName)
        {
            string actualProfileName = _personalDetailsPage.GetProfileName(expectedProfileName);
            Assert.That(actualProfileName, Is.EqualTo(expectedProfileName));
        }

        [Then("I should get all field with filled data")]
        public void ThenIShouldGetAllFieldWithFilledData()
        {

            if(_scenarioContext.TryGetValue("employeeDt",out DataTable dt))
            {
                //access the username
                //use same datatable and verify it 
                Console.WriteLine(dt.Rows[0]["firstName"]);
                Console.WriteLine(dt.Rows[0]["middleName"]);
                Console.WriteLine(dt.Rows[0]["lastName"]);
            }

            
            if(_scenarioContext.TryGetValue("username",out string output))
            {
                Console.WriteLine(output);
            }
        }
    }
}
