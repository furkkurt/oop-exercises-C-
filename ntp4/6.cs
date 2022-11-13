using System;

class Program{
  static int getGreaterNumber(int a, int b){
    if(a>b)
      return a;
    return b;
  }

  public static void Main(string[] args){
    int n1, n2;
    Console.Write("First number:  ");
    n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Second number: ");
    n2 = Convert.ToInt32(Console.ReadLine());

    int greaterNum = getGreaterNumber(n1, n2);

    Console.WriteLine("The greater number is {0}", greaterNum);
    Console.WriteLine("The greater number is " + greaterNum);
  }
}

