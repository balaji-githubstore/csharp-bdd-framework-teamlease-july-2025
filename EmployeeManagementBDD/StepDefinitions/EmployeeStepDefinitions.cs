using System;
using Reqnroll;

namespace EmployeeManagementBDD.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions
    {
        [When("I click on PIM menu")]
        public void WhenIClickOnPIMMenu()
        {
            
        }

        [When("I click on Add Employee menu")]
        public void WhenIClickOnAddEmployeeMenu()
        {
            
        }

        [When("I fill the employee form")]
        public void WhenIFillTheEmployeeForm(DataTable dataTable)
        {
            Console.WriteLine(dataTable);
            //FILL THE FIRSTNAME, MIDDLENAME, LASTNAME
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
            
        }
    }
}
