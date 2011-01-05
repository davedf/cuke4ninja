package ninjasurvivalrate;
import java.util.Arrays;
import java.util.Collection;
public class Ninja {
	private String belt;
	public Ninja (String belt){
		this.belt=belt;
	}
	public Collection<String> attackedBy(String opponent){
		if ("Chuck Norris".equals(opponent))
			return Arrays.asList(new String[]{"run for his life"});
		else 
			return Arrays.asList(new String[]{"engage the opponent"});
	}
	public String impact(String target,String opponent,String weapon){
		if (!belt.equals("third")) return "split";
		if (opponent.equals("Chuck Norris")) return "split";
		return "not harmed";
	}
}
