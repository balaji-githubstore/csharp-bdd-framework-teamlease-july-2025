@login
Feature: Login
 In order to manage employee records 
 As an Admin
 I want to login to the employee dashboard 

Background:
	Given I have browser with OrangeHRM application

	@regression @smoke
Scenario: Valid Login
	When I enter username as "Admin"
	And I enter password as "admin123"
	And I click on login
	Then I should access to portal with header as "Time at Work"

	@regression   @invalid 
Scenario Outline: Invalid Login
	When I enter username as "<username>"
	And I enter password as "<password>"
	And I click on login
	Then I should not get access with error as "<expected_error>"
Examples:
	| username | password | expected_error      |
	| saul     | saul123  | Invalid credentials |
	| peter    | peter123 | Invalid credentials |

	


