using System;

class Program{
  static void Main(){
    Array arr = Array.CreateInstance(typeof(int), 5, 4 ,3);
    Random rand = new Random();

    for (int i=0; i<arr.GetLength(0); i++)
      for (int j=0; j<arr.GetLength(1); j++)
        for (int k=0; k<arr.GetLength(2); k++){
          arr.SetValue(rand.Next(0,10), i, j, k);
          Console.WriteLine("arr[{0},{1},{2}]={3,3}",i,j,k,arr.GetValue(i,j,k));
        }
      
  }
}
