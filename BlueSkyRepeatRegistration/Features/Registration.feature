Feature: Registration
	In order to use the same data for my test
	As a guru QA
	I want to make some changes

@mytag
Scenario: Register With Same Data
	Given I navigate to the site"https://www.qa.giftrete.com"
	When I click on create account
	And I click on Register
	And i enter firt name "Kamsi"
	And I enter last name "Ezeh"
	And I enter email address "nelytino@yahoo.com"
	And I enter mobile number "07495712394"
	And i enter password "nnenna123"
	And I eneter confirm password "nnenna123"
	When I click on Register bottun
	Then Message "Rorgot password?"
