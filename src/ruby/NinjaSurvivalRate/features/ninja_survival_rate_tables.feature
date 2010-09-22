Feature: Fight or flight
  In order to increase the ninja survival rate,
  As a ninja commander
  I want my ninjas to decide whether to take on an 
  opponent based on their skill levels

#START:singletable
  Scenario: Fully armed 
    Given a ninja with the following experience
      | belt_level  | katana | sake     | fought  | magic |
      | third       | two    | three    | samurai | five  |
    When attacked by a samurai
    Then the ninja should engage the opponent
#END:singletable
