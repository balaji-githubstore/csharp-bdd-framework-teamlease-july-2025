Feature: Employee
In order to manage employee records
As an admin
I want to add, edit, delete employee details 

Scenario Outline: Add Valid Employee Record
	Given I have browser with OrangeHRM application
	When I enter username as "<username>"
	And I enter password as "<password>"
	And I click on login
	And I click on PIM menu
	And I click on Add Employee menu
	And I fill the employee form
		| firstName | middleName    | lastName |
		| <fname>   | <middle_name> | <lname>  |
	And I click on save employee
	Then I should get the profile name as "<fname> <lname>"
	And I should get all field with filled data
Examples:
	| username | password | fname | middle_name | lname   |
	| Admin    | admin123 | saul  | G           | goodman |
	#| Admin    | admin123 | john  | w           | wick    |



