Feature: TenString
	In order to test the way you think
	As a user 
	I want to see all all the 10-substring-friendly numbers between 0 and any positive number I enter

@mytag
Scenario: Find all 10 substring friendly numbers for the number 100
	Given I have entered 100 into the calculator
	When I press calculate
	Then the result should be 19, 28, 37, 46, 55, 64, 73, 82, 91 on the screen

	Scenario: Find all 10 substring friendly numbers for the number 19
	Given I have entered 19 into the calculator
	When I press calculate
	Then the result should be 19 on the screen

	Scenario: Find all 10 substring friendly numbers for the number 0
	Given I have entered 0 into the calculator
	When I press calculate
	Then the result should be the error message "0 10 substrings found" 0
