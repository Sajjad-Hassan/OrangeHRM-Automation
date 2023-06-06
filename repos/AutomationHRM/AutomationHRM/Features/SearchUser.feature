Feature: Search User

@Functionality
Scenario: Go to the admin dashboard and search for a system user
	Given Go the the website URL
	When Enter your usernam and password
	And Click on Admin
	Then Verify if you are on the system user page
	And Enter username 
	And Enter User role
	And Enter Employee name
	And Enter employee status
	When Click on search button
	Then Show records
