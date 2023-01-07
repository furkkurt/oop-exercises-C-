using System;

class A {
  public int a;

  public A() {
    a = 1;
  }

  public void print() {
    Console.WriteLine(a); //1
  }
}

class T:A {
  public new int a;
  public int b;

  public T() {
    a = 2;
    b = base.a;
  }
  
  public new void print() {
    base.print(); //1
    Console.WriteLine(a); //2
    Console.WriteLine(b); //1
  }
}

class Program {
  public static void Main() {
    T t = new T();
    A a = new A();

    a.print();
    t.print();
  }
}
