Feature: WebApi
	Since the 10-Substring is going to be used primarily on the web
	As a testing
	I want the WebApi to expose the features of the 10-Substring library

@mytag
Scenario: Get all values from a RESTful interface
	Given I have entered 19 into the service url
	When I invoke the service
	Then the result should be 19 from the service

Scenario: Find all 10 substring values from a RESTful interface
	Given I have entered 100 into the service url
	When I invoke the service
	Then the result should be 19, 28, 37, 46, 55, 64, 73, 82, 91 from the service url
