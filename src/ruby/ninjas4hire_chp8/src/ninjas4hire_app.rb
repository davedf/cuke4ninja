require 'rubygems'
require 'sinatra/base'
class Ninjas4HireApp < Sinatra::Base
	get '/cukeTest' do
		"up"
	end
end

