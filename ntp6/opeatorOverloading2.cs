using System;

class Program{
  public int x, y;
  
  public Program(int dd, int ff){
    x = dd;
    y = ff;
  }

  public void print(){
    Console.WriteLine(x+" "+y);
  }

  public static Program operator +(Program a, Program b){
    int c = a.x + a.y; int z = b.x + b.y;
    return new Program(c, z);
  }
}

class Class{
  static void Main(){
    Program a = new Program(5, 8);
    Program b = new Program(7, 9);

    Program c = a + b;
    c.print();
  }
}
