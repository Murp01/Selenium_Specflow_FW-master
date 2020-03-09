Feature: Search_Feature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Use search term to search for products 
	Given I am on the Morrisons home page
	And I have type '<searchTerm>' into the site search bar
	When I press the Go button on the site search bar
	Then the search results will retrieve '<searchTerm>'
	Examples: 
	| searchTerm |
	| crisps     |
	| fruit      |
	| cereal     |
