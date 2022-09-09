Feature: ProductsInCart

A short summary of the feature

@Ui
Scenario: View Products selected on cart
	Given I am in the Sauce Page
	When I set username as "standard_user"
	And I set password as "secret_sauce"
	And I click login button
	And I Click on BagPack Item
	And I Click on AddCart
	And I click on Cart Button
	Then I should be in cart page "https://www.saucedemo.com/cart.html"
	And Should be a bagpack item with price "29.99"
