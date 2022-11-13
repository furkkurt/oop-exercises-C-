using System;

class Program{
  static void Main(){
    int[] arr1 = {1,2,3,4,5,6,7};
    int[] arr2 = new int[10];
    int[] arr3 = new int[10];

    arr1.CopyTo(arr2,2); //0012345670
    
    foreach(int i in arr2)
      Console.Write(i);
    Console.WriteLine();

    Array.Copy(arr1, 2, arr3, 5, 3); //0000034500 arr1'in 2. indisten itibaren 3 karakterini arr3'ün 5. indisinden itibaren yapıştırıyor.

    foreach(int i in arr3)
      Console.Write(i);
    Console.WriteLine();  
  }
}
