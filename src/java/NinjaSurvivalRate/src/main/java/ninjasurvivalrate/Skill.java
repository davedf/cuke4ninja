package ninjasurvivalrate;
import java.util.Arrays;
import java.util.Collection;

public class Skill{
	private String name;
	public Skill(String name){
		this.name=name;
	}
	public boolean availableTo(String opponent){
		if ("Chuck Norris".equals(opponent)) return true;
		if ("roundhouse-kick".equals(name)) return false;
		return true;		
	}
	public String getDanger(String opponent){
		if ("Chuck Norris".equals(opponent)) return "extreme";
		if ("samurai".equals(opponent) && "katana".equals(name)) return "high";
		return "low";
	}
	public String getName(){
		return name;
	}
}