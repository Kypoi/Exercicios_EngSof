// See https://aka.ms/new-console-template for more information

using NeedForSpeed;

public class main{
  public static void Main(string[] args){
    int speed = 5;
    int batteryDrain = 2;
    RemoteControlCar car = new RemoteControlCar(5, 15);
    RaceTrack track1 = new RaceTrack(800);
    track1.TryFinishTrack(car);
  }
}