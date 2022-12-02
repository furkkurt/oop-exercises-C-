using System;

class Class{
  private int n;
  public int this[int i, int j]{
    get{return i+j+n;}
    set{n=i*j+value;}
  }
}
class Program{
  static void Main(){
    Class a = new Class();
    a[5, 4]=45;
    Console.WriteLine(a[-6,12]); //71
  }
}
