using System;

class automobile{
  protected double length = 5;
  protected double weight = 800;
  protected string color = "Yellow";
  public void print() {
    Console.WriteLine("Length: " + length);
    Console.WriteLine("Weight: " + weight);
    Console.WriteLine("Color: " + color);
  }
}

class model1:automobile {
  public string type;
  public int cylinders;
  public int valves;
  public int tork;
  public int power;
  public void printSpecs(){
    Console.WriteLine("Type: " + type);
    Console.WriteLine("Length: " + length);
    Console.WriteLine("Weight: " + weight);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Cylinders: " + cylinders);
    Console.WriteLine("Valves: " + valves);
    Console.WriteLine("Tork: " + tork);
    Console.WriteLine("Power: " + power);
  }
}

class model2:automobile {
  public double model2_length {
    get {return length;}
    set {length = value;}
  }
  public double model2_weight{
    get {return weight;}
    set {weight = value;}
  }
  public string model2_color{
    get {return color;}
    set {color = value;}
  }
  public string type="Hatchback";
  public int cylinders = 8;
  public int valves = 16;
  public int tork = 300;
  public int power = 210;
  public void printSpecs() {
    Console.WriteLine("Type: " + type);
    Console.WriteLine("Length: " + model2_length);
    Console.WriteLine("Weight: " + model2_weight);
    Console.WriteLine("Color: " + model2_color);
    Console.WriteLine("Cylinders: " + cylinders);
    Console.WriteLine("Valves: " + valves);
    Console.WriteLine("Tork: " + tork);
    Console.WriteLine("Power: " + power);
  }
}

class Program {
  static void Main() {
    model1 car1 = new model1();
    model2 car2 = new model2();

    car1.type="Sedan";
    car1.cylinders = 4;
    car1.valves = 8;
    car1.power = 75;
    car1.tork = 100;
    car1.printSpecs();
    Console.WriteLine("**********");
    car2.model2_length = 6;
    car2.model2_weight = 900;
    car2.model2_color = "Red";
    car2.printSpecs();
    Console.WriteLine("**********");
    car2.print();
    Console.WriteLine("**********");
    car1.print();
  }
}
