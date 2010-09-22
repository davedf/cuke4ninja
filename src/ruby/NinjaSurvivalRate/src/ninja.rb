# ninja!
class Ninja
	def initialize (belt_level)
		@belt=belt_level
	end
	def attacked_by (opponent)
		if (opponent=="Chuck Norris")
			["run for his life"]
		else
			["engage the opponent"]
		end
	end
end
