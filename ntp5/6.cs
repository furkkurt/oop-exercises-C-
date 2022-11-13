using System;

class Program{
  static class Rectangle{
    public static int width = 20;
    public static int length = 5;
    public static int Area(){
      int Area = width * length;
      return Area;
    }
    static void Main(){
      Console.WriteLine("Width:{0,5}",width);
      Console.WriteLine("Length:{0,4}",length);
      Console.WriteLine("Area:{0,6}",Area());
    }
  }
}
