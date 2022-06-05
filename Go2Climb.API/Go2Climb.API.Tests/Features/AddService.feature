Feature: AddService
As Agency I want to add my services so that my clients can see them

@service-adding
Scenario: Add a new service 
    Given the agency wants to add new service 
    When owner add a service
    Then the service will be added 