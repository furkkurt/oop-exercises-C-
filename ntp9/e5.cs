using System; 

class A {
  public int a;

  public A (int a) {
    this.a = a;
    Console.WriteLine("Constructor A\n");
  }
}

class B:A {
  public int b;
  public B(int a, int b):base(a) {
    this.b = b;
    Console.WriteLine("Constructor B\n");
  }
}

class C:B {
  public int c;
  public C(int a, int b, int c):base(a,b) {
    this.c = c;
    Console.WriteLine("Constructor C\n");
  }
}

class Program {
  static void Main() {
    Console.WriteLine("Object C");
    Console.WriteLine("**********");
    C c = new C(2,3,4);
    Console.WriteLine("a="+c.a);
    Console.WriteLine("b="+c.b);
    Console.WriteLine("c="+c.c+"\n");

    Console.WriteLine("Object B");
    Console.WriteLine("**********");
    B b = new B(5,6);
    Console.WriteLine("a="+b.a);
    Console.WriteLine("b="+b.b+"\n");

    Console.WriteLine("Object A");
    Console.WriteLine("**********");
    A a = new A(7);
    Console.WriteLine("a="+a.a+"\n");
  }
}
