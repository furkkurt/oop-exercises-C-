using System;

class A {
  virtual public void method() {
    Console.WriteLine("A");
  }
}

class B:A {
  override public void method() {
    Console.WriteLine("B");
  }
}

class Program {
  static void Main() {
    A objA = new A();
    B objB = new B();
    objA = objB;
    objA.method();
  }
}
