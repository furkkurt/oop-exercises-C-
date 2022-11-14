using System;

class Class{
  //Referans tipleri const yerine readonly ile tanımlanır
  readonly int[]a = {1,5,8};
  readonly object b = 5;

  static void Main(){
    Class n = new Class();
    Console.WriteLine(n.a[0]);
    Console.WriteLine(n.b);
  }
}
