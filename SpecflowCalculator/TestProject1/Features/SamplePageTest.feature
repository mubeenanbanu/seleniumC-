Feature: SamplePageTest
	Sample page test to fill basic information

@SamplePage
Scenario: Fill the Data in Sample Test Page
	Given Sample page in test
	Then enter name in Name textbox
	Then enter email in Email textbox
	Then select experience in years from Dropown
	Then enter the comment in Comment field
	Then click on Submit button
	Then close the Driver instance

@SamplePage
Scenario: Simple dropdown
	Given Date picker page in Sample page
	Then click on Date field
	Then select Month and Year from table
	Then select Date 
	Then Close the Driver instance
