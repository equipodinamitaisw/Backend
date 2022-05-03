Feature: ContractServiceToAgency
As a tourist I wish to hire a service offered by an agency in order to visit a place.

@servicescontracting
Scenario: The tourist wishes to contract the service of an agency
    Given the tourist is on the home page
    And and select the service you wish to contract
    When fills in the requested information to request the service
    | Date       | People
    | 05-05-2022 | 5
    Then click on contract