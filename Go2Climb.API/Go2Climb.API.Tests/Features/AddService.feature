Feature: AddService
	As Agency I want to add my services so that my clients can see them

@service-adding
Scenario: Add a new service 
	Given the agency wants to add on service endpoint
	When owner add a new service
	  | Name        | Price | Location | CreationDate | Description                         | AgencyId
	  | New Service | 720   | Cuzco   | 03-05-2022   | New service for my agency | 1
	Then the service will be added successfully