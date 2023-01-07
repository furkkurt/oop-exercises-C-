using System;

abstract class stdScore {
  public int visa;
  public int final;

  public stdScore(int v, int f) {
    visa = v;
    final = f;
  }
}

class std:stdScore {
  public string str;

  public std(string name, int visa, int final):base(visa,final){
    str=name;
  }

  public void printName(){
    Console.WriteLine("Student Name: " + str);
    Console.WriteLine("Visa Score:" + visa + " Final Score: " + final);
  }
}

class Program {
  static void Main() {
    std furk =new std("Furkan Kurt",70,80);
    furk.printName();
  }
}
