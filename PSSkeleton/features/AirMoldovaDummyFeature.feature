Feature: AirMoldova dummy testing

Scenario: Negative login
	Given user is populating login form with john.doe@email.com and password combination
	When user clicks Ok button
	Then THE ENTERED COMBINATION OF E-EMAIL AND PASSWORD IS NOT CORRECT, PLEASE TRY AGAIN. USER NOT EXIST WITH THIS VALUES. error message appears
