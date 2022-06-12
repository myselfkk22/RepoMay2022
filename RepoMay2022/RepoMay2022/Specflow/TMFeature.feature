Feature: TMFeature

As a TurnUp portal admin
I would like to create, edit and delete Time and Meterialrecords
so that i can manage Employee's time and materials successfully
@Create
Scenario: 1 Create time and material record with valid data
	Given I logged into turn poratl successfully
	When I navigate to Time and Material page
	And I created a new Time and Material record
	Then The record should be created successfully

@Edit
Scenario: 2 Edit existing time and material record
Given I logged into turn poratl successfully
When I navigate to Time and Material page
When I update '<Description>','<Code>','<Price>' on an existing time and material record
Then the record should have the updated '<Description>', '<Code>', '<Price>'


Examples: 
| Description  | Code   | Price    |
| Keyboard     | May666 | $16.00   |
| Pendrive     | Phone1 | $150.00  |
| EditedRecord | Portal | $49.00   |

