Feature: Add Employee

@Functionality
Scenario: Add a new employee and validate 
	Given Go To the Url
	When enter your username and password
	And Click on PIM page
	And Click on Add Button
	Then validate if you are on the Add employee page
	And Enter First name
	And Enter middle name
	And EnterLastname
	And Enter Employee ID
	When Click on Save button
	Then Validate if your record is added
