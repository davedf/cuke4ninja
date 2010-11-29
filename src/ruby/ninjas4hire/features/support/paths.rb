# Taken from the cucumber-rails project.

module NavigationHelpers
  # Maps a name to a path. Used by the
  #
  #   When /^I go to (.+)$/ do |page_name|
  #
  # step definition in web_steps.rb
  #
  def path_to(page_name)
    case page_name

#START:hello
    when /the home\s?page/
      '/'
	#Add these lines
	when /^the cucumber test page$/
	  '/cukeTest'
	#end of added lines
    else
      raise "Can't find mapping from \"#{page_name}\" to a path.\n" +
        "Now, go and add a mapping in #{__FILE__}"
    end
#END:hello
  end
end

World(NavigationHelpers)
