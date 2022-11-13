using System;

class Program{
  public static void Main(string[] args){
    string[] names = {"ali", "ahmet", "selda", "canan", "melike"};
    Console.WriteLine("Enter a name: ");
    
    string entry = Console.ReadLine();

    foreach(string name in names){
      Console.WriteLine(entry);
      if(entry.Equals(name))
        Console.WriteLine("Person found!");
      else
        Console.WriteLine("Not a person found with the name "+entry);
    }
  }
}
