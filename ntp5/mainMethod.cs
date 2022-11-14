using System;

class Program{
  static void Main(string[] args){
    Console.WriteLine("Entries: ");
    foreach(string entry in args)
      Console.WriteLine(entry);
  }
}
