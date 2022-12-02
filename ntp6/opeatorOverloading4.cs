using System;

class Time{
  public int Hour;
  public int Minute;
  public int Second;

  public Time(int hour, int minute, int second){
    Minute = minute+second/60;
    Second = second%60;
    Hour = hour+minute/60;
    Minute=Minute%60;
  }

  public static Time operator + (Time a, Time b){
    int totalSec = a.Second + b.Second;
    int totalMin = a.Minute + b.Minute;
    int totalHour = a.Hour + b.Hour;
    return new Time(totalHour, totalMin, totalSec);
  }

  public static Time operator + (Time a, int b){
    int totalSec = a.Second + b;
    return new Time(a.Hour, a.Minute, totalSec);
  }
}

class Program{
  static void Main(){
    Time t1 = new Time(5,5,5);
    Time t2 = new Time(6,6,6);
    Time t3 = t1 + t2;
    Console.WriteLine(t3.Hour + " " + t3.Minute + " " + t3.Second); //11 11 11
    Time t4 = t3 + 5;
    Console.WriteLine(t4.Hour + " " + t4.Minute + " " + t4.Second); //11 11 16
  }
}
