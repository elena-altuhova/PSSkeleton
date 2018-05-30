Feature: Book A Flight 

Scenario: Book A Flight
	Given user accesses Menu
	And user selects 'Book a flight' option
	When user selects 'Barcelona' in Destination field
	Then available flights are shown