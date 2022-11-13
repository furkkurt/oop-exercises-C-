using System;
class Program{
  public static void Main(string[] args){
    int i=0, a, n;

    Console.Write("Bir sayı girin: ");
    n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Artım miktarını girin: ");
    a = Convert.ToInt32(Console.ReadLine());
    
    for(; i<n; ){
      Console.Write("{0} ", i);
      i+=a;
    }
  }
}
