using System;

class Program{
  static void Method1(float x, float y){
    Console.WriteLine("Method 1");
  }

  static void Method1(double x, double y){
    Console.WriteLine("Method 2");
  }

  public static void Main(string[] args){
    Method1(5.0,6);
    Method1(5,6.4f);
  }
}
