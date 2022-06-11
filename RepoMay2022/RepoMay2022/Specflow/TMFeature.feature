Feature: TMFeature

As a TurnUp portal admin
I would like to create, edit and delete Time and Meterialrecords
so that i can manage Employee's time and materials successfully

Scenario: 1 Create time and material record with valid data
	Given I logged into turn poratl successfully
	When I navigate to Time and Material page
	And I created a new Time and Material record
	Then The record should be created successfully



