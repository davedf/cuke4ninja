# encoding: utf-8
require 'rspec/expectations' 
require 'cucumber/formatter/unicode'

$:.unshift(File.dirname(__FILE__) + '/../../src')
require 'skill'

#START:raw
Given /^the following skills are allowed$/ do |table|
	@skill_list=table.raw.flatten.map {|skill| Skill.new(skill) }
end
#END:raw

When /^a ninja faces [a\s]*(.*)$/ do |opponent|
	@opponent=opponent
end

#START:diff
Then /^he should expect the following attack techniques$/ do |table|
	actual_skill_list=[]
	@skill_list.each do |skill|
		if skill.available_to @opponent then
			actual_skill_list << 
			   { "technique" => skill.name, 
			     "danger" => skill.danger(@opponent) }
		end
	end
	table.diff! actual_skill_list
end
#END:diff
