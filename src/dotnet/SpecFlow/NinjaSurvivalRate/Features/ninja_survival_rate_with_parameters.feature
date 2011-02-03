Feature: Fight or flight With Parameters Example
  In order to increase the ninja survival rate,
  As a ninja commander
  I want my ninjas to decide whether to take on an 
  opponent based on their skill levels

  Scenario: Fully armed 
	Given a ninja with the following parameterized experience
	 |Field		|Value		|
	 |BeltLevel	|third		|
	 |Katana	|two		|
	 |Sake		|three		|
	 |Fought	|samurai	|
	 |Magic		|five		|

	When attacked by a samurai
	Then the ninja should engage the opponent
