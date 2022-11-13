using System;

class Program{
  static float function(float x){
    return 2*x+5;
  }

  static float reverseFunction(float x){
    return (x-5)/2;
  }

  public static void Main(string[] args){
    float x = 10;
    Console.WriteLine(function(x)); //25
    Console.WriteLine(reverseFunction(x)); //2.5
    Console.WriteLine(function(reverseFunction(x))); //10
  }
}
