Feature: SearchService
	as a tourist i want to optimize my search using diferent filters

@mytag
Scenario: As a tourist i want to filter by name
	Given the tourist wants to travel
	When the tourist types the name of the service
	Then the app will display the results
	
Scenario: As a tourist i want to filter by price range
	Given the tourist wants to travel
	When the tourist types the name of the service
	And types the target price
	Then the app will display the results