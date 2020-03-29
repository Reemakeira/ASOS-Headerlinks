Feature: ASOSHeaderlinks
	In order to view Headers
	As a user
	I want to see the Headers

@Headers
Scenario Outline: Navigate to Headers
	Given I Navigate to ASOS
	When I Click on <Headers>
	Then I see <Headers> pages

	Examples: 
	| Headers  |
	| Clothing |
	| Shoes    |
