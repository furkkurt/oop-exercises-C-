using System;

delegate Father fatherDelegate();
delegate Son sonDelegate();

class Father { 
  public Father() {
    Console.WriteLine("Father was born");
  }
}
class Son : Father { 
  public Son() {
    Console.WriteLine("Son was born");
  }
}


class Program {
  static Son sonMethod() { return new Son(); }
  static Father fatherMethod() { return new Father(); }

  static void Main() {
    fatherDelegate fatherObj = new fatherDelegate(fatherMethod);
    fatherObj();

    sonDelegate sonObj = new sonDelegate(sonMethod);
    sonObj += new sonDelegate(sonMethod);
    sonObj();
      //Aşağıdaki kod hatalı
    //sonObj = new sonDelegate(fatherMethod)
  }
}
