using System;

class Program{
  static void Method1(int x, int y, int z){
    Console.WriteLine("Method 1");
  }

  static void Method1(int x, int y){
    Console.WriteLine("Method 2");
  }  
 
  static void Method1(float x, int y){
    Console.WriteLine("Method 3");
  }

  public static void Main(string[] args){
    Method1(3,3,6); //Method 1
    Method1(3.4f,3); //Method 3
    Method1(1, 'g'); //Method 2
  }
}
