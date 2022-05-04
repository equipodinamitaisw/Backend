Feature: MonitorClients
	As an agency i want to monitor the activity of my clients

@mytag
Scenario: Change status to active
	Given the user is logged in 
	And clicks on the clients tab
	When he changes service the status to active
	Then the status will be updated
Scenario: Change status to finished
	Given the user is logged in 
	And clicks on the clients tab
	When he changes service the status to finished
	Then the status will be updated to finished
	