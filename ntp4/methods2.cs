using System;

class Program{
  static int Add(params int[] nums){
    int total = 0;
    
    foreach(int n in nums)
      total += n;
    return total;
  }
  static void Main() {
    Console.WriteLine(Add());
    Console.WriteLine(Add(5));
    Console.WriteLine(Add(5, 10));
    Console.WriteLine(Add(5, 10, 16));
  }
}
