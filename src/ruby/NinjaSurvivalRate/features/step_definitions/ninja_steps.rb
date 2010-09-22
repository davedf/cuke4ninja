# encoding: utf-8
require 'spec/expectations' 
require 'cucumber/formatter/unicode'

$:.unshift(File.dirname(__FILE__) + '/../../src')
require 'ninja'

#START:belt
Given /^the ninja has a ([a-z]*) level black\-belt$/ do |belt_level|
	@ninja=Ninja.new :belt_level => belt_level 
end
#END:belt

#START:attacked
When /^attacked by [a\s]*(.*)$/ do |opponent|
	@actions=@ninja.attacked_by(opponent)
end
#END:attacked

#START:actions
Then /^the ninja should (.*)$/ do |expected_action|
	@actions.should include expected_action
end
#END:actions

#START:singletable
Given /^a ninja with the following experience$/ do |table|
   @ninja=Ninja.new table.hashes.first
end
#END:singletable
