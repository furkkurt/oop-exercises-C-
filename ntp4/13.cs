using System;

class Program{
  static void print(object o){
    Console.WriteLine("Method 1:" + o);
  }

  static void print(params object[] o){
    if(o.Length == 0)
      return;
    Console.Write("Method 2:");
    foreach(object n in o)
      Console.Write(n.ToString() + " ");
    Console.WriteLine();
  }

  public static void Main(string[] args){
    print(25); //Method 1
    print("text1", "text2"); //Method 2
    print('a'); //Method 1
    print('z', 1, 23f, 4, 56, "abc"); //Method 2
  }
}
