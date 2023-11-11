Feature: StudentLogin

Students can log in to their profiles

@login
Scenario: Student Logs in to HBAP profile
  Given  that I am on the profile <profile> and environment <environment>	
    When  open the EdAid Homepage 
	And  enter a valid HBAP Student email
	And  I enter the valid password
	Then  am logged in to my account landing page
	And close the browser instance

			Examples:
		| profile  | environment      |
		| single   | Firefox          |
		| parallel | Chrome           |
		| parallel | Firefox          |
		| parallel | Safari           |
		| parallel | InternetExplorer |

	@login
Scenario: Student Logs in to IPP profile
  Given  that I am on the profile <profile> and environment <environment>	
    When I open the EdAid Homepage 
	And  enter a valid IPP Student email
	And  I enter the valid password
	Then I am logged in to my account landing page
	And close the browser instance	

			Examples:
		| profile  | environment      |
		| single   | Firefox          |
		| parallel | Chrome           |
		| parallel | Firefox          |
		| parallel | Safari           |
		| parallel | InternetExplorer |

	@login
Scenario: Student Logs in to DPP profile
  Given  that I am on the profile <profile> and environment <environment>	
    When  I go to the EdAid Homepage 
	And  I enter a valid DPP Student email
	And  I enter the valid password
	Then  I am logged into my account landing page
	And close the browser instance


		Examples:
		| profile  | environment      |
		| single   | Firefox          |
		| parallel | Chrome           |
		| parallel | Firefox          |
		| parallel | Safari           |
		| parallel | InternetExplorer |