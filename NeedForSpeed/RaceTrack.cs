namespace NeedForSpeed;

public class RaceTrack{
	//attributes
	private int distance = 800;
	
	//getters and setters
	public int Distance{
		get { return distance; }
		set { this.distance = value; }
	}
	//constructor
	public RaceTrack(int distance){
		this.distance = distance;
	}

	//methods
}