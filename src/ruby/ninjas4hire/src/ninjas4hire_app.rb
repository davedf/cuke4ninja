require 'rubygems'
require 'sinatra/base'
#require (File.dirname(__FILE__)+ "/regexRouteFilter")

class Ninjas4HireApp < Sinatra::Base
#  register Sinatra::RegexpRouteFilter
#	before_with_regexp(/^((?!\/config).)*$/) do
#		if (@configuration.nil?)
#		  redirect '/config', 301
#		end
#	end
	get '/cukeTest' do
		"up"
	end
end
