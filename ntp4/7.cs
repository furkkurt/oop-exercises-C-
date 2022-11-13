using System;

class Program{
  static int getGreaterNum(int a, int b){
    if (a>b)
      return a;
    return b;
  }
  static int getGreaterOf3(int a, int b, int c){
    return getGreaterNum(a, getGreaterNum(b,c));
  }
  public static void Main(string[] args){
    int n1, n2, n3;
    Console.WriteLine("Enter three numbers:");
    n1 = Convert.ToInt32(Console.ReadLine());
    n2 = Convert.ToInt32(Console.ReadLine());
    n3 = Convert.ToInt32(Console.ReadLine());
    int greatestNum = getGreaterOf3(n1, n2, n3);
    Console.WriteLine("The greatest number is: " + greatestNum);
  }
}
