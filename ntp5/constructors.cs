using System;

class Test{
  public Test(){Console.WriteLine("No parameters");}
  public Test(string a){Console.WriteLine("1 parameters");}
  public Test(string a, string b){Console.WriteLine("2 parameters");}
  public Test(string a, string b, string c){Console.WriteLine("3 parameters");}
}

class Program{
  public static void Main(string[] args){
    Test test = new Test("5", "6");
  }
}
