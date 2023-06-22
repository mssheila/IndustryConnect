Feature: TMFeature

As a Turn Up portal admin, 
I would like to create and edit time and material records.
So that I can manage the employees' time and material successfully.

Scenario: Create time and material record with valid details
	Given I logged into turn up portal successfully
	When I navigate to Time and Material page
	And I create a new time and material record
	Then The record should be created successfully

Scenario Outline: Edit existing time and material record with valid details
	Given I logged into turn up portal successfully
	When I navigate to Time and Material page
	And I update '<Description>', '<Code>' and '<Price>' and edit an existing time and material record
	Then The record should have the updated '<Description>', '<Code>' and '<Price>'

Examples:
| Description  | Code          | Price |
| Time         | Whatever      | 7     |
| Material     | Bags          | 1678  |
| EditedRecord | SomethingElse | 1.238 |

