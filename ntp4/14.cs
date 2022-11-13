using System;

class Program{
  static int factorial(int a){
    if (a==0)
      return 1;
    return a*factorial(a-1); //Fonksiyon kendi içinde çağırıldı. (RECURSIVE)
  }

  public static void Main(string[] args){
    Console.Write("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Factorial of {0} is {1}", num, factorial(num));
  }
}
