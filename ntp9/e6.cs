using System;

class A {
  public void method1() {
    method2();
  }
  public void method2() {
    Console.WriteLine("Class A");
  }
}

class B:A {
  /*
  public new void method1() {
    method2();
  }
  */
  //Yukarıdaki yorum kısmı açık olursa B olmazsa A yazar
  
  public new void method2() {
    Console.WriteLine("Class B");
  }
}

class Program {
  static void Main() {
    B b = new B();
    b.method1();
  }
}
