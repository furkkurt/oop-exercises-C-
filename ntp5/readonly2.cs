using System;

class Class{
  int a = 5;
  static readonly Class obj = new Class();
  
  static void Main(){
    Console.WriteLine(obj.a);
  }
}
