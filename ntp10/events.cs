using System;

delegate void EventHandler();

class Button {
  public event EventHandler handler;

  public void click() {
    if (handler != null)
      handler();
  }
}

class Program {
  static void method1(){Console.WriteLine("method1");}
  static void method2(){Console.WriteLine("method2");}
  static void click(){Console.WriteLine("button clicked");}

  public static void Main() {
    Button but = new Button();
    but.handler += new EventHandler(click);
    but.handler += new EventHandler(method1);
    but.handler += new EventHandler(method2);
    but.click();
  }
}
