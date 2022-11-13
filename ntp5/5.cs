using System;

class Program{
  class Rectangle{
    public int width;
    public int length;
    public int Area(){
      int Area = width*length;
      return Area;
    }
    public void SetWL(int width, int length){
      this.width = width;
      this.length = length;
    }
    public void Write(){
      Console.WriteLine("***********");
      Console.WriteLine("Width:{0,5}",width);
      Console.WriteLine("Length:{0,5}",length);
      Console.WriteLine("Area:{0,5}",Area());
      Console.WriteLine("***********");
    }
    public static void Main(string[] args){
      Rectangle r1 = new Rectangle();
      r1.SetWL(20,50);
      r1.Write();
      Rectangle r2 = new Rectangle();
      r2.SetWL(25,12);
      r2.Write();
    }
  }
}
