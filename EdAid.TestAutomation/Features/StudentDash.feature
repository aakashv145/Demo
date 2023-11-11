Feature: StudentDash

Students can view and interact with their dashboard

@studash
Scenario: Student navigates dashboard
  Given  that I am on the profile <profile> and environment <environment>	
    When  I go to the EdAid Homepage 
	And  I enter a valid DPP Student email
	And  I enter the valid password
	Then I am logged into my account landing page
	And I can see Funding information
	And I can see Payment Method information
	And close the browser instance

	
		Examples:
		| profile  | environment      |
		| single   | Firefox          |
		| parallel | Chrome           |
		| parallel | Firefox          |
		| parallel | Safari           |
		| parallel | InternetExplorer |

@studash
Scenario: Scenario: Student can view and change their settings
  Given  that I am on the profile <profile> and environment <environment>	
    When  I go to the EdAid Homepage 
	And  I enter a valid DPP Student email
	And  I enter the valid password
	Then I am logged into my account landing page
	And I can click Account Settings from the hamburger menu
		And I can view my sign up journey
	And I can update my information
	And close the browser instance

	
		Examples:
		| profile  | environment      |
		| single   | Firefox          |
		| parallel | Chrome           |
		| parallel | Firefox          |
		| parallel | Safari           |
		| parallel | InternetExplorer |


		@studash
Scenario: Student can view and change their payment method
  Given  that I am on the profile <profile> and environment <environment>	
    When  I go to the EdAid Homepage 
	And  I enter a valid DPP Student email
	And  I enter the valid password
	Then I am logged into my account landing page
	And I can click Switch Payment Account button
	And I can select an alternative payment
	And I can click Change Default button to confirm
	And close the browser instance

	
		Examples:
		| profile  | environment      |
		| single   | Firefox          |
		| parallel | Chrome           |
		| parallel | Firefox          |
		| parallel | Safari           |
		| parallel | InternetExplorer |
