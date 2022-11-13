using System;

class Program{
  static void createArr(int[] a, int pattern){
    if(pattern == 0){
      foreach(Object o in a)
        Console.Write(o.ToString() + " ");
      Console.WriteLine();
    }
    else if(pattern == 1){
      int x=1;
      foreach(Object o in a){
        Console.Write("{0,5}",o.ToString());
        if(x%3==0)
          Console.WriteLine();
        x++;
      }
    }
    else{
      foreach (Object o in a)
        Console.WriteLine(o.ToString());
    }
    Console.WriteLine();
  }

  public static void Main(string[] args){
    int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9};
    createArr(arr, 0);
    createArr(arr, 1);
    createArr(arr, 2);
  }
}
