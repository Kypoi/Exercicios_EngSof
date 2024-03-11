// See https://aka.ms/new-console-template for more information

using NeedForSpeed;

public class main{
  public static void Main(string[] args){
    int speed = 5;
    int batteryDrain = 2;
    var car = RemoteControlCar.Nitro();
    car.Drive();
    car.Drive();
    car.DistanceDriven();
    car.BatteryDrained();
  }
}