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
	public bool TryFinishTrack(RemoteControlCar car) {
		Console.WriteLine($"{(car.Speed * (100/ (double)car.BatteryDrain))}!!!!!!");
		if ((car.Speed * (100/ (double)car.BatteryDrain)) > this.distance) {
			Console.WriteLine($"O carro consegue!{car.Speed * (100/ (double)car.BatteryDrain)}");
			return true;
		}else {
			Console.WriteLine($"O carro nao consegue!{car.Speed * (100/ (double)car.BatteryDrain)}");
			return false;
		}
	}
}