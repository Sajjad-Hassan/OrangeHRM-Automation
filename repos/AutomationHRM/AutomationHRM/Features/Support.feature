Feature: Support page Display

@Functionality
Scenario: Visibility of Support page
	Given Go to Home page
	When Enter valid username and password
	And Click on profile 
	And Click on support 
	Then Validate support page display
