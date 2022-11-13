using System;

class Program{
  static void method(double x, double y){
    Console.WriteLine("First method");
  }

  static void method(byte x, byte y){
    Console.WriteLine("Second method");
  }

  static void Main(){
    method(1919,1923);
    method(12,34);
  }
}
