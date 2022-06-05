Feature: EditInfo
	As an agency a want to edit my contact info

@mytag
Scenario: Required fields set
	Given the user is logged
	When Enters to profile 
	And clicks on edit info
	Then The info will be updated
	
