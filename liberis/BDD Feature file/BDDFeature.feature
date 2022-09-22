Feature: Liberis get a demo

Testing Liberis website and its partner selection page while selecting type of partner


Scenario: 1 Set implicit wait on the driver
	Given Set implicit wait on the driver


Scenario: 2 Select I'm a Broker button
	Given I'm on Become a partner page
	When I select "I'm a Broker" button
	And click get demo
	Then I should be on 'https://www.liberis.com/become-a-partner/broker-iso-form' page


Scenario: 3 Select I'm an ISO button
	Given I'm on Become a partner page
	When I select "I'm an ISO" button
	And click get demo
	Then I should be on 'https://www.liberis.com/become-a-partner/broker-iso-form' page


Scenario: 4 Select I'm a Strategic Partner button
	Given I'm on Become a partner page
	When I select "I'm a Strategic Partner" button
	And click get demo
	Then I should be on 'https://www.liberis.com/become-a-partner/strategic-partner-form' page


Scenario: 5 Do not select any button
	Given I'm on Become a partner page
	When click get demo
	Then I should get validation message