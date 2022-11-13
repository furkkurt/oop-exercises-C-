using System;

class Program{
  public static void Main(string[] args){
    Random random = new Random();
    int[] arrInt = new int[20];
    char[] arrChar = new char[20];

    for(int i=0; i<20; i++){
      arrInt[i] = random.Next(1, 51);
      arrChar[i] = (char)random.Next(20, 126);
    }
    for (int i=0; i<20; i++){
      Console.Write("{0,2}. değer {1,2} -> ", i, arrInt[i]);
      for(int j=0; j<arrInt[i]; j++)
        Console.Write(arrChar[i]);
      Console.WriteLine();
    }
  }
}
