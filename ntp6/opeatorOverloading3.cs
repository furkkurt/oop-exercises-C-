using System;

class Class{
  public int Num;
  public Class(int num){
    Num = num;
  }
  public static bool operator true (Class a){
    return true;
  }
  public static bool operator false (Class b){
    return false;
  }
  public static Class operator & (Class a, Class b){
    return new Class(20);
  }
  public static Class operator | (Class a, Class b){
    return new Class(30);
  }
}

class Program{
  static void Main(){
    Class a = new Class(50);
    Class b = new Class(10);
    Console.WriteLine((a||b).Num);
    Console.WriteLine((a&&b).Num);
  }
}
