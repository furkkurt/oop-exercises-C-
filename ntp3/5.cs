using System;
class Program{
  public static void Main(string[] args){
    int secim;
    do {
      Console.WriteLine("İşlemler\n=========");
      Console.WriteLine("1 - Topalama");
      Console.WriteLine("2 - Çıkarma");
      Console.WriteLine("3 - Çarpma");
      Console.WriteLine("4 - Bölme");
      Console.WriteLine("0 - Çıkış");
      Console.WriteLine("İşleminizi Seçin:");
      secim = Convert.ToInt32(Console.ReadLine());
      switch (secim){
        case 1: Console.WriteLine("Toplama işlemi seçildi."); break;
        case 2: Console.WriteLine("Çıkarma işlemi seçildi."); break;
        case 3: Console.WriteLine("Çarpma işlemi seçildi."); break;
        case 4: Console.WriteLine("Bölme işlemi seçildi."); break;
        case 0: Console.WriteLine("Çıkış seçildi."); break;
        deafult: Console.WriteLine("Yanlış seçim"); break;
      }
    } while(secim!=0);
  }
}
