using System;
class Class{
  public int n;
  public int this[int index]{
    get{return n;}
    set {
      if(index>0)
        n+=value;
      else
        n-=value;
    }
  }
}
class Program{
  static void Main(){
    Class a = new Class();
    a[5]=45;
    a[-10]=23;
    a[100]=87;
    a[-80]=100;
    Console.WriteLine(a[0]); //9
  }
}
