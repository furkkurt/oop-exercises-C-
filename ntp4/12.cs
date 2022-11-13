using System;

class Program{
  static int calculate(string operation, params int[] nums){
    if(operation=="multiply"){
      if (nums.Length == 0)
        return 1;
      int result = 1;
      foreach (int i in nums)
        result *= i;
      return result;
    }
    else if(operation=="add"){
      if (nums.Length == 0)
        return 0;
      int result = 0;
      foreach (int i in nums)
        result += i;
      return result;
    }
    else return 0;
  }

  public static void Main(string[] args){
    Console.WriteLine(calculate("add",3,4,5,8));
    Console.WriteLine(calculate("multiply",5,23,6));
  }
}
