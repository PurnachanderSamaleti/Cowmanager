Feature: Top_Nav_bar

Test the Top navigation bar

Background: 
	Given Enter a valid username
	When enter a valid password
	And click on keep me sign in button then it should not ask next time for re-login
	Then click on Sign in button

	Scenario: Test the cow manager logo
	When click on CowManager logo
	And it should be Navigate to a new tab
	And enter a data on search box
	Then come back to parent tab

	Scenario: Test the search box on navigation bar
	When entering a text data on search box
	And click on the search button
	And it should navigate to a new tab
	And click on the Language button
	Then come back parent tab

	Scenario: Testing the support community on navigation  bar
	When click on support community
	And it should navigate a new tab
	And click on the trending topiics
	Then it should come back to parent tab
	
	Scenario: Test the change password functionality
	When click on userfield it should show the logout change password buttons
	And click on change password button it should navigate to a new page and ask enter old password
	And enter old password
	And enter the new password
	And enter the confirm password
	Then click on continue button it should navigate into the application

	Scenario: Test the logout functionality
	When click on userfield it shows logout and change password
	And click the logout button
	Then it should navigate to the login page and shows welcome back