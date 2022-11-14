using System;

class Test{
  Test(int a, int b, int c){
    Console.WriteLine(a+b+c);
  }
  Test():this(0,0,0){
  }
  Test(int a):this(a,0,0){}
  Test(int a, int b):this(a,b,0){}

  static void Main(){
    Test a = new Test(5,6);
    Test b = new Test();
  }
}
