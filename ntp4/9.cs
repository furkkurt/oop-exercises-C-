using System;

class Program{
  static void thirty(int num){
    num = 30;
  }

  public static void Main(string[] args){
    int x = 100;
    Console.WriteLine(x); //100
    thirty(x);
    Console.WriteLine(x); //100
  }
}
