using System;
using System.Collections; //list için lazım

class Program{
  static void Main(){
    ArrayList list = new ArrayList();
    list.Add("Ahmet");
    list.Add(34);
    list.Add('A');

    foreach(dynamic item in list)
      Console.Write(item + " ");
    Console.WriteLine();

    list.Remove('A');

    foreach(dynamic item in list)
      Console.Write(item + " ");
    Console.WriteLine();
  }
}
