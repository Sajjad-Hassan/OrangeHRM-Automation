Feature: Employee Information

@Functionality
Scenario: Enter employee information and search for it.
	Given Go To The Url.
	When Enter username and password
	And Click on PIM
	When Enter employee information
	Then validate if employee is present