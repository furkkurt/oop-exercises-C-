using System;

class Animal {
  public double height;
  public double weight;
  public void print() {
    Console.WriteLine("Height: "+height);
    Console.WriteLine("Weight: "+weight);
  }
  public Animal(){
    Console.WriteLine("Animal Created!");
  }
}

class Cat : Animal {
  public string kind;
  public void printKind() {
    Console.WriteLine("Kind: " + kind);
  }
  public Cat() {
    Console.WriteLine("Cat Created!");
  }
}

class Program {
  static void Main() {
    Cat cat1 = new Cat();
    cat1.weight = 5;
    cat1.height = 10;
    cat1.kind = "Van";
    cat1.print();
    cat1.printKind();
    
    Console.WriteLine();
    Animal animal1 = new Animal();
    animal1.weight = 5;
    animal1.height = 10;
    animal1.print();
  }
}
