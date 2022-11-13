using System;

class Program{
  static void Main(){
    string[] arr = {"Zeynep", "Fatma", "Ali", "Yılmaz", "Gökhan", "Osman", "Feride"};

    foreach(string name in arr)
      Console.Write(name + " ");
    Console.WriteLine();
    
    Array.Sort(arr); //Alfabetik sıralar

    foreach(string name in arr)
      Console.Write(name + " ");
    Console.WriteLine();
  }
}
