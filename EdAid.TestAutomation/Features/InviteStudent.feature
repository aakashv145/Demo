Feature: InviteStudent

School Admin invites a student to apply for EdAid

@InviteStudent
Scenario:  As a school Admin, I can invite a student to apply for EdAid
	Given that I am on the profile <profile> and environment <environment>
	When I go to the EdAid Landing Page 
	And  I enter a valid school admin email
	And  I enter the valid password
	And  I click login button
	And  I click the invite student button
	And  I enter valid student details
	And  I click Invite Student button
	Then Success message is displayed
	And  I can close the Invite window 
	And  close the browser instance


				Examples:
		| profile  | environment      |
		| single   | Firefox          |
		| parallel | Chrome           |
		| parallel | Firefox          |
		| parallel | Safari           |
		| parallel | InternetExplorer |


		@InviteStudent
Scenario:  As a school Admin, I cannot invite a student to apply with invalid/missing information
	Given that I am on the profile <profile> and environment <environment>
	When I go to the EdAid Landing Page 
	And  I enter a valid school admin email
	And  I enter the valid password
	And  I click login button
	And  I click the invite student button
	And  I enter invalid student details
	And  I click Invite Student button
	Then Validation message is displayed
	And  I can close the Invite window 
	And  close the browser instance


				Examples:
		| profile  | environment      |
		| single   | Firefox          |
		| parallel | Chrome           |
		| parallel | Firefox          |
		| parallel | Safari           |
		| parallel | InternetExplorer |
