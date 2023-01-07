using System;

namespace quiz{
  class Program{
    public static void Main(String[] args){
      int[] nums = new int[15];
      int[] compressed = new int[15];
      for(int i = 0; i<15; i++)
        nums[i] = Int32.Parse(Console.ReadLine());
      
      compressed[0] = nums[0];
      for(int i = 1; i<15; i++){
        compressed[i] = nums[i]-nums[i-1];
      }
      
      foreach(int n in compressed)
        Console.Write(n+" ");

      Console.WriteLine();
      Console.Write("215541013 Ahmet Furkan Kurt");
    }
  }
}
