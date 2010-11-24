Given /^I am "([^"]*)"$/ do |who_am_i|
end

When /^I am told "([^"]*)"$/ do |alive_name|
  visit path_to(alive_name)
end

Then /^I shout "([^"]*)"$/ do |shout|
  page.body.should  =~ Regexp.new(Regexp.escape(shout))
end
