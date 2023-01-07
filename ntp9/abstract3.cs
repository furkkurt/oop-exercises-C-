using System;

abstract class A {
  public int x;
  abstract public int y{get; set;}
  public A (int x) {
    this.x = x;
  }
  abstract public void Method();
}

class S:A {
  int z;
  public S(int x):base(x){}

  public override int y{
    get {return z;}
    set {z=value;}
  }

  public override void Method(){
    Console.WriteLine(x);
    Console.WriteLine(y);
  }
}

class Program {
  static void Main() {
    S s = new S(5);
    s.y = 2 * s.x;
    s.Method();
  }
}
