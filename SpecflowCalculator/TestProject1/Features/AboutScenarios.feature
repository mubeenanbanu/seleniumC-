Feature: AboutScenarios
	Using Table to print more than 1 data

@Table

Scenario:Add Employee Details using Table class
#Given sample application
When i enter all the details
| Name    | Experience | Phone      | title             |
| Mubeena | 3          | 9635688899 | software engineer |
| Sanobar | 5      | 9635611111 | senior software engineer |
| banu | 5         | 9635688899 |  engineer |


@Scenariooutline
Scenario Outline:Add Employee Details using Table class with scenario outline
#Given sample application
When I enter all the details in form <Name>,<Experience>,<Phone>,<title>

Examples: 
| Name    | Experience | Phone      | title             |
| Mubeena | 3          | 9635688899 | software engineer |
| Sanobar | 5      | 9635611111 | senior software engineer |
| banu | 5         | 9635688899 |  engineer |