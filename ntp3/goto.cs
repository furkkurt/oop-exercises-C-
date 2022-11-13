using System;

class Program{
  static void Main(){
    int m=0;
    int n=10;
    start:
    m++;
    if (m<=n) goto start;
    else goto end;
    end: Console.WriteLine("m="+m);
  }
}
