using System;

class GetSet{
  int n;

  public int fakeProperty{
    set{
      if(value < 0)
        n = 0;
      else
        n = value;
    }

    get{
      if(n>100)
        return n/100;
      else
        return n;
    }
  }
}
class Program{
  static void Main(){
    GetSet obj = new GetSet();
    obj.fakeProperty = 110;
    Console.Write(obj.fakeProperty);
  }
}
