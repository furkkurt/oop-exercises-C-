using System;

class A {
  virtual public int varA{
    set{}
    get{return 12;}
  }
}

class B:A {
  override public int varA{
    get{return 100;}
    set{Console.WriteLine("Echo");}
  }
  static void Main(){
    A objA = new A();
    B objB = new B();
    objA=objB;
    Console.WriteLine(objB.varA);
    objB.varA=200;
  }
}
