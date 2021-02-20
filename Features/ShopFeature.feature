@Shop
Feature: ShopFeature
	As a user
	I want to add items to the cart from shop and see them in the cart

Scenario: TC04_As a user I want to add items to the cart from shope page and see then in the cart
	Given I am in the shop page
	When I click buy button 2 times on Funny Cow
	And I click buy button 1 times on Fluffy Bunny
	Then I Click the cart menu
	And I can see items count in the cart matching with the added items
	And I can see 2 items of Funny Cow in the cart
	And I can see 1 items of Fluffy Bunny in the cart