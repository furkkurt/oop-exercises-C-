//Düzensiz diziler
using System;

class Program{
  public static void Main(string[] args){
    int [][] arr = new int [3][];

    arr[0] = new int[] {1,2};
    arr[1] = new int[] {3,4,5,6,7};
    arr[2] = new int[] {8,9,0};

    foreach (int[] dimenson in arr){
      foreach (int item in dimenson){
        Console.Write("{0,3}", item);
      }
      Console.WriteLine();
    }
  }
}
