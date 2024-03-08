using System.Collections.Immutable;

namespace Exercicios1;

public class BirdCount{
  //attributes
  private static ImmutableArray<int> lastWeek = new();
  private int[] birdsPerDay = [2, 5, 0, 7, 4, 1 ];
  
  //constructor 
  public BirdCount(){
  }

  //getters & setters
  public int[] BirdsPerDay{
    get => birdsPerDay;
    set => birdsPerDay = value ?? throw new ArgumentNullException(nameof(value));
  }

  //methods
  public static ImmutableArray<int> LastWeek(){
    return [0, 2, 5, 3, 7, 8, 4];
  }

  public int Today(){
    return 1;
  }
}