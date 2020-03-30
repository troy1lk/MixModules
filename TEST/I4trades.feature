Feature: I4trades
	In order to view Headers
	As a math user
	I want to be able to click on those

@headers
Scenario Outline: Verify I4trade Headers
	Given I navigate to I4trades
	And I click on <headers>
	Then I see <headers> page
	Examples: 
	| headers	            |
	| Trades Business Owner |
	| Organisations         |
	| Trades Consumer       |

