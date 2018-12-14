Feature: ThailandTask
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen


@ThaiLandTrip
Scenario:Attractions in Tailand
	Given I have Navigated to the TaiLand Home Page 'https://www.tourismthailand.org/'
	And I Clicked on Attractions
	When I moved to Sights and Attractions Section
	Then I hovered on Moresights and Attractions 
	Then The following attractions will be displayed in new tabs
	


