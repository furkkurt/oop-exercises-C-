using System;

abstract class A {
  abstract public int varA {set; get;}
}

class B:A {
  override public int varA {
    get {
      return 100;
    }
    set {
      Console.WriteLine("Echo");
    }
  }

  static void Main() {
    B objB = new B();
    Console.WriteLine(objB.varA);
    objB.varA = 200;
  }
}
