require 'rspec/expectations' 
require 'cucumber/formatter/unicode'

@@killed=0
@@remaining=3

Before do
  @@killed=@@killed+1 
end

After do |scenario|
  @@remaining=@@remaining-1
end

When /^this scenario is executed$/ do
  # do absolutely nothing
end

Then /^[A-z ]* should kill one ninja$/ do
  @@killed.should == 1 
end

Then /^[A-z ]* should kill (\d+) ninjas$/ do |expected|
  expected.to_i.should == @@killed 
end

Then /^[A-z ]* should expect (\d+) ninjas$/ do |expected|
  expected.to_i.should == @@remaining
end  
