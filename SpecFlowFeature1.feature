Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen


@Opening
Scenario: Moving to home Page
	Given I have entered 'https://www.google.com/?gws_rd=ssl' into address bar
	And I have entered 'hai images' into the Search Box
	When I press enter
	Then the result should be displayes on the screenmk


@example_outline
Scenario Outline: Passing the Values
	Given I have Navigated to 'https://www.google.com/?gws_rd=ssl'
	And  entered '<text>' into the Search Box
	Then I Search the text
	When I enter
	Then the result will be displayed
	Examples: 
	| text              |
	| chiranjevi Images |
	| RamCharan Images  |



