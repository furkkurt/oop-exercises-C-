using System;

delegate void EventHandler();

class Program {
  static void Main() {
    Program obj = new Program();

    obj.Event = new EventHandler(method1); //Olay sonrası işlenecek metodun eklenmesi
    obj.Event(); //Olayın gerçekleşmesi
  }

  static void method1() {
    Console.WriteLine("Button clicked");
  }
  
  event EventHandler Event; //Olay bildirimi
}
