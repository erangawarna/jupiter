@Contact
Feature: ContactFeature
	As a user
	I want to create new contacts

Scenario: TC01_As a user I want to verify validation errors when not populate mandatory and populate
	Given I am in the contact page
	When I click submit button
	Then I should see validation errors
	When I populate mandtory fields with valid data
	Then the validation errors should go away

Scenario: TC02_As a user I want to save a contact successfully
	Given I am in the contact page
	When I populate mandtory fields with valid data
	And I click submit button
	Then I should see the successful submission message

Scenario: TC03_As a user I want to see validation errors for invalid data
	Given I am in the contact page
	When I populate mandtory fields with invalid email
	Then I should see validation error for invalid email