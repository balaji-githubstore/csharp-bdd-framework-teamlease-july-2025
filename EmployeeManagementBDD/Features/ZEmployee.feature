#Feature: Employee
#In order to manage employee records
#As an admin
#I want to add, edit, delete employee details 
#
#Scenario: Add Valid Employee Record
#	Given I have browser with OrangeHRM application
#	When I enter username as "Admin"
#	And I enter password as "admin123"
#	And I click on login
#	And I click on PIM menu
#	And I click on Add Employee menu
#	And I fill the employee form 
#	| firstName | middleName | lastName |
#	| John      | w          | wick     |
#	And I click on save employee 
#	Then I should get the profile name as "John wick"
#	And I should get all field with filled data
#
#Scenario: Add Valid Employee Record2
#	Given I have browser with OrangeHRM application
#	When I enter username as "Admin"
#	And I enter password as "admin123"
#	And I click on login
#	And I click on PIM menu
#	And I click on Add Employee menu
#	And I fill the employee form 
#	| firstName | middleName | lastName |
#	| Peter      | w          | wick     |
#	And I click on save employee 
#	Then I should get the profile name as "Peter wick"
#	And I should get all field with filled data
