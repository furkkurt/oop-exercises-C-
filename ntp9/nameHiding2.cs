using System;

class X {
  protected int a;
  public X(int a) {
    Console.WriteLine("X " + a);
    this.a = a;
  }
  public int A {
    get {
      Console.WriteLine("Class X= " + a);
      return a;
    }
  }
}

class Y:X {
  protected int b;
  public Y(int a):base(a) {
    Console.WriteLine("Y " + a);
    this.b = a;
  }

  new public int A {
    get {
      Console.WriteLine("Class Y= " + b);
      return b;
    }
  }
}

class Program {
  static void Main() {
    Y y = new Y(5);
    X x = new X(6);

    int n = y.A;
    int n2 = x.A;
  }
}
