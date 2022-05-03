Feature: ViewServiceValoration
As a tourist I want to see the ratings of other users with each agency to know if the agency is safe or trustworthy.

    @servicesvaloration-viewing
    Scenario: View ratings from an agency that has qualifications
        Given the tourist would like to see ratings from an agency
        And  click on the agency's website
        Then in the reviews section you will be able to visualize the valuation of the agency