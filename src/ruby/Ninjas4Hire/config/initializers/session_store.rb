# Be sure to restart your server when you modify this file.

# Your secret key for verifying cookie session data integrity.
# If you change this key, all old sessions will become invalid!
# Make sure the secret is at least 30 characters and all random, 
# no regular words or you'll be exposed to dictionary attacks.
ActionController::Base.session = {
  :key         => '_Ninjas4Hire_session',
  :secret      => '6043a1b8bb2a252176faaef19e8f82b810d0a28a7cf688152dd3d3b829db73980b34222bcb8527630b5dda21f8aa233e32f5640aaa906551d2e05e801a15bf31'
}

# Use the database for sessions instead of the cookie-based default,
# which shouldn't be used to store highly confidential information
# (create the session table with "rake db:sessions:create")
# ActionController::Base.session_store = :active_record_store
