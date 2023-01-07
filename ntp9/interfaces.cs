using System;

interface I {
  void method();
}

class C:I {
  void I.method() {
    Console.WriteLine("Echo");
  }
}

class program {
  static void Main() {
    C obj = new C();
    ((I)obj).method();
  }
}
