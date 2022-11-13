using System;
class Program{
  public static void Main(string[] args){
    int sayi;
    Console.Write("Bir tam sayı giriniz: ");
    sayi = Convert.ToInt32(Console.ReadLine());

    for (int bit=32; bit>=1; bit--){
      Console.Write("{0}", (sayi >> bit-1) & 1);
    }
    Console.WriteLine();
  }
}
