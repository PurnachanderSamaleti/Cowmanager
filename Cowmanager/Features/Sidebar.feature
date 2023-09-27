Feature: Sidebar

Test the side bar

Background: 
	Given Enter a valid username
	When enter a valid password
	And click on keep me sign in button then it should not ask next time for re-login
	Then click on Sign in button

	Scenario: Test the input button
	When click on input button it displays input sub items
	Then click again input button now it should hide the input sub items

	Scenario: Test the nutrition button
	When click on nutrition button it should display the nutrition sub items
	Then click again nutrition button now it should hide the nutrition sub items

	Scenario: Test the find my cow button
	When click on find my cow it should display the find my cow sub items
	Then click again on find my cow now it should hide the find my cow sub items

	Scenario: Test the settings button
	When click on settings it should open the setings sub items
	Then click again on settings button now it should hide the settings sub items

	Scenario: Test the system status button
	When click on system status it should open the sub items of system status
	Then click again on system status now it should hide the sub items of system status

	Scenario: Test the membership button
	When click on membership button it should open the membership sub item
	Then click again on membership button now it should hide the sub item of membership button
