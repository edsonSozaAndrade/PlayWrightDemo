Feature: SauceLogin

A short summary of the feature

@Ui
Scenario: Login With correct credentials
	Given I am in the Sauce Page
	When I set username as "standard_user"
	And I set password as "secret_sauce"
	And I click login button
	Then I should be in home page "https://www.saucedemo.com/inventory.html"
