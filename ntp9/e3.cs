using System;

class Cat {
  protected int foots = 4;
  public void catchPrey() {
    Console.WriteLine("Cat cought the prey");
  }
}

class Tiger:Cat {
  public Tiger() {
    Console.WriteLine("Foots: " + foots);
  }
}

class Program {
  static void Main() {
    Cat cat = new Cat();
    cat.catchPrey();

    Tiger tiger = new Tiger();
    tiger.catchPrey();
  }
}
