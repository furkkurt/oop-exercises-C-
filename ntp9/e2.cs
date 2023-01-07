using System;

class A {
  public int x;
  private int y;
  protected int z;

  public A() {
    x = 1;
    y = 2;
    z = 3;
    Console.WriteLine("Constructor A");
  }

  public void list(){
    Console.WriteLine("x={0}; y={1}; z={2}",x,y,z);
  }
}

class T:A {
  public string s;

  public T() {
    s = "Inherited Class";
    Console.WriteLine("Constructor T");
  }

  public void print(){
    Console.WriteLine("s={0}; x={1}; z={2}",s,x,z);
  }
}

class Program {
  static void Main() {
    T t = new T();
    t.list();
    t.print();
  }
}
