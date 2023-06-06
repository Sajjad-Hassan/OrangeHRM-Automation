Feature: Logout Functionality


@Functionality
Scenario: Proceed to Logout after logging in
	Given Go to Home Page 
	When Enter Valid username and Password
	And Click on Profile 
	And Click on Logout
	Then Validate Logout
