using System;

class Program{
  static void Main(){
    string[] arr = {"Zeynep", "Fatma", "Ali", "Yılmaz", "Gökhan", "Osman", "Feride"};

    string query = Console.ReadLine();
    Array.Sort(arr);
    int indexOfQuery = Array.BinarySearch(arr, query);
    
    if(indexOfQuery < 0)
      Console.WriteLine("Could not find entry");
    else
      Console.WriteLine("Entry found at index {0}", indexOfQuery);
  }
}
