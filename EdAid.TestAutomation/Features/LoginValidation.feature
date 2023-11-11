Feature: LoginValidation

Incorrect email or password does not allow log in

@LoginValidation
Scenario: As a user, I attempt log in with incorrect password

	Given  that I am on the profile <profile> and environment <environment>
	When I open the edaid homepage
	And I enter valid email
	And I enter invalid password
	And I click login
	Then error message is displayed
	And close the browser instance

	Examples:
		| profile  | environment      |
		| single   | Firefox          |
		| parallel | Chrome           |
		| parallel | Firefox          |
		| parallel | Safari           |
		| parallel | InternetExplorer |


	@LoginValidation
Scenario: As a user, I attempt log in with incorrect email

	Given  that I am on the profile <profile> and environment <environment>
	When I open th edaid homepage
	And I enter invalid email
	And  I enter the valid password
	And I select login
	Then error message displayed
	And close the browser instance

	Examples:
		| profile  | environment      |
		| single   | Firefox          |
		| parallel | Chrome           |
		| parallel | Firefox          |
		| parallel | Safari           |
		| parallel | InternetExplorer |

