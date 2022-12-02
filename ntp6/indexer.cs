using System;

class Class{
  public int n;
  public int this[int index]{
    get {
      return n;
    }
    set {
      n = value;
    }
  }
}

class Program{
  static void Main(){
    Class a = new Class();
    a[5] = 30;
    Console.WriteLine(a[5]); //30 yazar
  }
}
