using System;

class Program{
  public static void Main(string[] args){
    int[,] arr= {{2,3},{4,5},{6,7}};
    arr[2,1]=33;
    Console.WriteLine(arr.GetValue(2,1)); //33
    Console.WriteLine(arr[2,1]); //33

    //Düzensiz dizi, her satırda farklı sayıda eleman var
    int[][] arr2 = new int[2][];
    arr2[0] = new int[2];
    arr2[1] = new int[1];
    arr2[0][0] = 23;
    arr2[0][1] = 234;
    arr2[1][0] = 44;
    Console.WriteLine(arr2[1][0]); //44
    
    //
    Random random = new Random();
    int[] arr3 = new int[3];
    arr3[0] = random.Next(2, 10);
    arr3[1] = random.Next(50);
    arr3[2] = random.Next();
    Console.WriteLine(arr3.GetValue(2)); //Random int
  }
}
