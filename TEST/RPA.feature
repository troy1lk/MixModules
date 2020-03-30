Feature: RPA
	In order to win RPA challange
	As a user
	I want be able to submit details

@submit
Scenario: submit detaila
	Given I navigate to RPA
	And I enter login details
	When I click on submit button
	Then I verify the RPA page
