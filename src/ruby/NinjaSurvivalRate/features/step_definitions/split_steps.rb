require 'rspec/expectations' 
require 'cucumber/formatter/unicode'

$:.unshift(File.dirname(__FILE__) + '/../../src')
require 'ninja'
require 'impact_calculator'

When /^hit on the head by [a ]*([A-z ]*) with a ([A-z]*)$/ do |opponent, weapon|
  @opponent=opponent
  @weapon=weapon
end

Then /^the ninja's ([A-z]*) should ([A-z]*)$/ do |target,expected_impact|
  impact_c=ImpactCalculator.new
  actual_impact=impact_c.impact @ninja,@opponent,@weapon,@target
  actual_impact.should==expected_impact 
end

Then /^the ninja's ([A-z]*) should not be harmed$/ do |target|
  impact_c=ImpactCalculator.new
  actual_impact=impact_c.impact @ninja,@opponent,@weapon,@target
  actual_impact.should=="not harmed"
end

