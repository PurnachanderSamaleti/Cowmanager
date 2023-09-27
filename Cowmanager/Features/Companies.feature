Feature: Companies

Test the companies functionalities

Scenario: Test the deleted companies button and show only network issues button
	When click on deleted functionality it should shows only deleted companies list
	Then click on show only network issues it should shows only network issues company list from deleted companies

	Scenario: Test the active companies button and show only network issues button
	When click on active button it should shows only active companies list
	Then click on show only network issues it should shows only network issues companies list from the active companies