Feature: ResetPassword 

As a user I can reset my password

@passwordreset
Scenario: User forgets password 
  Given  that I am on the profile <profile> and environment <environment>	
    When I click Forgotten your password? link 
	And  enter a valid email 
	And  I click Reset Password
	Then message is shown to confirm password reset email sent
	And I can click TAKE ME BACK TO SIGN IN link to return to the login page
	And close the browser instance

			Examples:
		| profile  | environment      |
		| single   | Firefox          |
		| parallel | Chrome           |
		| parallel | Firefox          |
		| parallel | Safari           |
		| parallel | InternetExplorer |
