namespace NeedForSpeed;

public class RemoteControlCar{
  //attributes
  private int speed;
  private int batteryDrain;
  private static int distanceDriven = 0;
  
  //Getters and Setters
  public int Speed{
    get { return this.speed; }
    set { this.speed = value; }
  }

  public int BatteryDrain{
    get { return this.batteryDrain; }
    set { this.batteryDrain = value; }
  }
  
  //constructors
  public RemoteControlCar(int speed,int batteryDrain){
    this.speed = speed;
    this.batteryDrain = batteryDrain;
  }

  public static RemoteControlCar Nitro(){
    RemoteControlCar car = new RemoteControlCar(50, 4);
    return car;
  }
  //methods
  public void Drive(){
    distanceDriven += this.speed;
    this.batteryDrain -= 1;
    Console.WriteLine($"+ {this.speed}!");
  }
  public void DistanceDriven(){
    Console.WriteLine($"O carro percorreu {distanceDriven} Km!");
  }

  public void BatteryDrained(){
    String msg;
    msg = (this.batteryDrain == 0) ? "The battery is drained" : "The battery is not drained, remaining : " + this.batteryDrain;
  }

}