using System;

delegate void EventHandler();

class Button {
  public EventHandler[] eventH = new EventHandler[3];
  public int i = 0;
  public int j = 0;

  public event EventHandler Event {
    add {
      Console.WriteLine("New method added to event ("+(i+1)+")");

      if (eventH[i]==null)
        eventH[i]=value;

      i++;
      if (i == 3){
        --i;
        Console.WriteLine("Event list is full");
      }
    }

    remove {
      Console.WriteLine("Method removed from event.");

      if(eventH[i] == value)
        eventH[i] = null;

      i--;
      if(i==-1)
        Console.WriteLine("Event not found");
    }
  }

  public void click() {
    for (int j = 0; j <= i; j++) {
      if(eventH[j] != null)
        eventH[j]();
    }
  }
}

class Program {
  static void method1() {Console.WriteLine("Method 1");}
  static void method2() {Console.WriteLine("Method 2");}
  static void click() {Console.WriteLine("Click");}
  
  static void Main() {
    Button but = new Button();
    but.Event += new EventHandler(click);
    but.Event += new EventHandler(method1);
    but.Event += new EventHandler(method2);
    but.Event -= new EventHandler(click);
    but.Event -= new EventHandler(method1);
    but.Event -= new EventHandler(method2);
  }
}
