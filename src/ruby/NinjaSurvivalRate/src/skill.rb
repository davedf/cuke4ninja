class Skill
  
  def initialize (name)
    @name=name
  end
  
  def available_to (opponent)
    if @name=="roundhouse-kick" then
      return opponent=="Chuck Norris"
    end
    true
  end
  
  def danger (opponent)
    if opponent=="Chuck Norris" then
       "extreme"
  	elsif opponent=="samurai" and @name=="katana" then
      "high"
  	else
      "low"
  	end
  end
  def name
    @name
  end
end