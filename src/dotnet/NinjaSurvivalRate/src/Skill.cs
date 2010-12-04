using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjaSurvivalRate
{
    class Skill
    {
        private String name;
	    public Skill(String name){
		    this.name=name;
	    }
	    public bool AvailableTo(String opponent){
		    if ("Chuck Norris" == opponent) return true;
		    if ("roundhouse-kick" == name) return false;
		    return true;		
	    }
	    public String Danger(String opponent){
		    if ("Chuck Norris" == opponent) return "extreme";
		    if ("samurai" == opponent && "katana" == name) return "high";
		    return "low";
	    }
	    public String Name(){
		    return name;
	    }
    }

}
