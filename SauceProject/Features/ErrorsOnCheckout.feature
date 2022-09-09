Feature: ErrorsOnCheckout

A short summary of the feature

@Ui
Scenario: Error on First Name
	Given I am in the Sauce Page
	When I set username as "standard_user"
	And I set password as "secret_sauce"
	And I click login button
	And I Click on BagPack Item
	And I Click on AddCart
	And I click on Cart Button
	And I clik on checkout button
	And I set last name as "Soza"
	And I set Zip code as "12345"
	And I click on Continue
	And I see error message for first name missing