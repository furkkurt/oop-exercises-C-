using System;

class complexNum{
  private double mReal;
  private double mImaginary;

  public double Real{
    get{
      return mReal;
    }
    set{
      mReal = value;
    }
  }

  public double Imaginary{
    get{
      return mImaginary;
    }
    set{
      mImaginary = value;
    }
  }

  public complexNum(double x, double y){
    mReal = x;
    mImaginary = y;
  }

  public complexNum(){
    mReal = 0;
    mImaginary = 0;
  }

  public complexNum(complexNum c){
    mReal = c.mReal;
    mImaginary = c.mImaginary;
  }

  public void print(){
    if (mImaginary>0)
      Console.WriteLine("{0}+{1}i", mReal, mImaginary);
    else
      Console.WriteLine("{0}-{1}i", mReal, -mImaginary);
  }

  public static complexNum operator + (complexNum a, complexNum b){
    double totalReal = a.Real + b.Real;
    double totalImaginary = a.Imaginary + b.Imaginary;
    return new complexNum(totalReal, totalImaginary);
  }

  public static complexNum operator - (complexNum a, complexNum b){
    double totalReal = a.Real - b.Real;
    double totalImaginary = a.Imaginary - b.Imaginary;
    return new complexNum(totalReal, totalImaginary);
  }

  public static bool operator == (complexNum a, complexNum b){
    if(a.Real == b.Real && a.Imaginary == b.Imaginary)
      return true;
    else
      return false;
  }
  
  public static bool operator != (complexNum a, complexNum b){
    return !(a==b);
  }
}

class Program{
  public static void Main(){
    complexNum c1 = new complexNum(-5,-6);
    complexNum c2 = new complexNum(4, 7);
    complexNum c3 = c1 + c2;
    c3.print();
    complexNum c4 = c1-c2;
    c4.print();
    //bool isEqual = c1 == c2;
    //complexNum c5 = new complexNum(4, 7);
    //bool isEqual2 = c1 == c5;
    //Console.WriteLine(isEqual, isEqual2);
  }
}
