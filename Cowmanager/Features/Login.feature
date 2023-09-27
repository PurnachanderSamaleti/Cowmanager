Feature: Login

Test the login shell

Background: 
	Given Enter a valid username
	When enter a valid password
	And click on keep me sign in button then it should not ask next time for re-login
	Then click on Sign in button
