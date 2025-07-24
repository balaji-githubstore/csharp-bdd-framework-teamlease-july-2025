
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
            Console.WriteLine(dataTable.RowCount);

           

            Console.WriteLine(dataTable.Rows[0][0]);
            Console.WriteLine(dataTable.Rows[0][1]);
            Console.WriteLine(dataTable.Rows[0][2]);

            Console.WriteLine(dataTable.Rows[0]["firstName"]);
            Console.WriteLine(dataTable.Rows[0]["middleName"]);
            Console.WriteLine(dataTable.Rows[0]["lastName"]);
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
