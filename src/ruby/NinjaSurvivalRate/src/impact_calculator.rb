class ImpactCalculator
  def impact (ninja, opponent, weapon, target)
    if ninja.nil? 
      raise "Ninja is not defined"
    end
    if ninja.belt? != "third" 
      return "split" 
    end
    if opponent=="Chuck Norris"
      return "split" 
    end
    "not harmed"
  end
end
