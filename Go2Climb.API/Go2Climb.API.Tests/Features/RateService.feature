Feature: RateService
	As a client i want to rate a sevice

@mytag
Scenario: The service is finished
	Given The client is logged
	And enters to his profile 
	When the client clicks on rate service
	Then he will be able to rate the service
Scenario: The service is not finished
	Given The client is logged
	And enters to his profile 
	When the client clicks on rate service 2
	Then he will not be able to rate the service