using System;

class Program{
  class ClassOperation{
    public int property1=55;
    public string property2="test";
    public float property3=123.78f;
    public int method1(int a, int b){
      return a+b;
    }
    public void method2(string a){
      Console.WriteLine(a);
    }
    public static void Main(string[] args){
      ClassOperation obj = new ClassOperation();
      Console.WriteLine(obj.property1);
      Console.WriteLine(obj.property2);
      Console.WriteLine(obj.property3);
      Console.WriteLine(obj.method1(2,5));
      obj.method2("test");
    }
  }
}
