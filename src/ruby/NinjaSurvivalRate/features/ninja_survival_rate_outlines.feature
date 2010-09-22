Feature: Fight or flight with outlines
  In order to increase the ninja survival rate,
  As a ninja commander
  I want my ninjas to decide whether to take on an 
  opponent based on their skill levels

  Scenario Outline: third-level ninjas engage samurai
    Given the ninja has a <belt level> level black-belt 
    When attacked by <opponent>
    Then the ninja should <expected action>

  Examples:
    |belt level |opponent     |expected action     |
    |third      |a samurai    |engage the opponent |
    |third      |Chuck Norris |run for his life    |
    |second     |a samurai    |run for his life    |
