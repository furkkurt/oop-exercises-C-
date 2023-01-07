using System;

public class Animal {
  protected string a = "Animal a";
  string b = "Animal b";
  private string c = "Animal c";
  public string d = "Animal d";
}

public class Cat:Animal {
  public Cat() {
    Console.WriteLine("Cat Cosnturected");
    Console.WriteLine(a);
    //Console.WriteLine(b); //HATA
    //Console.WriteLine(c); //HATA
    Console.WriteLine(d);
  }
}

class Program {
  public static void Main() {
    Cat cat = new Cat();
  }
}
