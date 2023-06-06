Feature: Reset Employee Information

@Fuctionality
Scenario: enter Employee Information and Reset it.
	Given go To The Url.
	When enter username and password
	And click on PIM
	When enter employee information
	Then velidate reset button
