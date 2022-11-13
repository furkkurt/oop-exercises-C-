using System;

class Program{
  public static int width = 30;
  public static int length = 23;
  public static int Area(){
    int Area = width*length;
    return Area;
  }
  static void Main(){
    Print d1 = new Print();
    d1.print();
  }
}
class Print{
  public void print(){
    Console.WriteLine("Length:{0,5}",Program.length);
    Console.WriteLine("Width:{0,6}",Program.width);
    Console.WriteLine("Area:{0,7}",Program.Area());
  }
}
