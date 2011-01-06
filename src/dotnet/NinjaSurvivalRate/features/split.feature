Feature: Split Brains
  Ninjas can receive training to withstand a direct hit on the head

  Scenario: Samurai katana is useless against a ninja >= 3rd level
    Given the ninja has a third level black-belt
    When hit on the head by a samurai with a katana
    Then the ninja's brains should not be harmed

  Scenario: Ninja training is useless against Chuck Norris
    Given the ninja has a third level black-belt
    When hit on the head by Chuck Norris with a fist
    Then the ninja's brains should split  
