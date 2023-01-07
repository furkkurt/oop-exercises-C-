using System;

class Program {
  public delegate void del();

  public static void Compute() {
    Console.WriteLine("Computer Science");
  }
  
  public static void Electric() {
    Console.WriteLine("Electronics");
  }

  public static void Main(){
    del obj = new del(Compute);
    obj();
    obj = new del(Electric);
    obj();
  }
}
