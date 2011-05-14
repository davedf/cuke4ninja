Feature: Skill availability
  As a ninja trainer, 
  I want ninjas to understand the dangers of various opponents 
  so that they can engage them in combat more effectively 

  Scenario: Samurai are dangerous with katanas, no advanced kicks
    Given the following skills are allowed
      | katana          |
      | karate-kick     |
      | roundhouse-kick |
    When a ninja faces a samurai
    Then he should expect the following attack techniques
      | technique     | danger | 
      | katana        | high   |
      | karate-kick   | low    |

  Scenario: Chuck Norris can do anything and is always dangerous 
    Given the following skills are allowed
      | katana          |
      | karate-kick     |
      | roundhouse-kick |
    When a ninja faces Chuck Norris
    Then he should expect the following attack techniques 
      | technique       | danger   |
      | katana          | extreme  |
      | karate-kick     | extreme  |    
      | roundhouse-kick | extreme  |
