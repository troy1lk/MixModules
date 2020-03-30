Feature: RightMoveRandomFields
	In order to check random fields of Right Move
	As a user
	I want be able to select random figures and verify the outcome

@randomfields
Scenario: Boundry Value Analysis for Right Move
	Given I have navigate to Right Move
	When I click on the fields using min medium maximum and mix inputs
	Then I see the page loads with search results
