Feature: Roman Numerals Converter, Acceptance tests
	To ensure that my Roman Numerals converter works as inteded
	It mus be able to perfomr correct calculations on the following numbers
	1999, 2444 & 90 and back to decimal integers

@ToRomanNumerals
Scenario: Convert 1999 to Roman Numeral
	Given I have entered 1999 into the converter
	When I press enter
	Then the result should be 'MCMXCIX' on the screen

Scenario: Convert 2444 to Roman Numeral
	Given I have entered 2444 into the converter
	When I press enter
	Then the result should be 'MMCDXLIV' on the screen

Scenario: Convert 90 to Roman Numeral
	Given I have entered 90 into the converter
	When I press enter
	Then the result should be 'XC' on the screen

@ToDecimal
Scenario: Convert MCMXCIX to Roman Numeral
	Given I have entered 'MCMXCIX' into the converter
	When I press enter
	Then the result should be 1999 on the screen

Scenario: Convert MMCDXLIV to Roman Numeral
	Given I have entered 'MMCDXLIV' into the converter
	When I press enter
	Then the result should be 2444 on the screen

Scenario: Convert XC to Roman Numeral
	Given I have entered 'XC' into the converter
	When I press enter
	Then the result should be 90 on the screen

@EdgeCases
Scenario: Try to convert -10
	Given I have entered -10 into the converter
	When I press enter
	Then the result shoudl be 'ArgumentOutOfRangeException' and a description on the screen

Scenario: Try to convert 0
	Given I have entered 0 into the converter
	When I press enter
	Then the result shoudl be 'ArgumentOutOfRangeException' and a description on the screen