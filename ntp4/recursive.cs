using System;

class Program{
  static void toBinary(int n){
    if(n==0) return; //olmazsa stack overflow hatası veriyor
    toBinary(n >> 1);
    Console.Write(n & 1);
  }

  static void Main(){
    toBinary(15); Console.WriteLine();
    toBinary(32); Console.WriteLine();
  }
}
