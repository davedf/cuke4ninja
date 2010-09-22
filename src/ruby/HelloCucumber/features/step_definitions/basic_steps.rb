require 'spec/expectations' 

Given /The Action is ([A-z]*)/ do |action|
  @action = action
end

When /The Subject is ([A-z]*)/ do |subject|
  @subject = subject
end

Then /The Greeting is (.*)/ do |greeting|
  greeting.should == "#{@action}, #{@subject}"
end

