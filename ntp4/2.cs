using System;

class Program{
  public static void Main(string[] args){
    int[,] mattress = {{1,2},{3,4},{5,6}};
    for(int i=0; i<3; i++){
      for(int j=0; j<2; j++){
        Console.Write(mattress[i,j]);
      }
      Console.WriteLine();
    }
  }
}
