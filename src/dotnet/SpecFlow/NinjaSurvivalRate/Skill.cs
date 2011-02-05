using System;

namespace NinjaSurvivalRate
{
	public class Skill
	{
		private readonly String name;

		public Skill(String name)
		{
			this.name = name;
		}

		public bool AvailableTo(String opponent)
		{
			if ("Chuck Norris" == opponent) return true;
			if ("roundhouse-kick" == name) return false;
			return true;
		}

		public String Danger(String opponent)
		{
			if ("Chuck Norris" == opponent) return "extreme";
			if ("samurai" == opponent && "katana" == name) return "high";
			return "low";
		}

		public String Name()
		{
			return name;
		}
	}
}