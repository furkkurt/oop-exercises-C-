using System;

class A {
  public int varA;
  
  public A(int a) {
    varA = a;  
  }
}

class B:A {
  public int varB;
  
  public B(int b, int a):base(a) {
    varB = b;  
  }
}

class C:B {
  public int varC;
  
  public C(int c, int b, int a):base(b,a) {
    varC = c;  
  }
}

class Program {
  static void Main() {
    C obj = new C(12,56,31);
    Console.WriteLine(obj.varA + " " + obj.varB + " " + obj.varC);
  }
}
