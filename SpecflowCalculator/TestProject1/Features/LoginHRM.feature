Feature: Login
	Login functionality of OrangeHRM App

@Login
Scenario: Login to OrangeHRM
	Given OrangeHRM testApp
	Then enter Username 
	And enter Password
	Then click on Login button
	Then verify whether login is successfull
	Then close the Driver instance for Login
