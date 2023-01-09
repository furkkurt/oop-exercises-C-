using System;

class Program {
  public delegate void commandMethod();

  public struct commandStruct {
    public commandMethod CommandMethod;
    public string Command;
  }

  public static void method1() {
    Console.WriteLine("Method 1");
  }

  public static void method2() {
    Console.WriteLine("Method 2");
  }

  public static void method3() {
    Console.WriteLine("Method 3");
  }

  public static void method4() {
    Console.WriteLine("Method 4");
  }

  static void Main() {
    commandStruct[] commands = new commandStruct[4];

    commands[0].Command = "komut1";
    commands[0].CommandMethod = new commandMethod(method1);
    commands[1].Command = "komut2";
    commands[1].CommandMethod = new commandMethod(method2);
    commands[2].Command = "komut3";
    commands[2].CommandMethod = new commandMethod(method3);
    commands[3].Command = "komut4";
    commands[3].CommandMethod = new commandMethod(method4);

    Console.WriteLine(commands[0].Command);
    commands[0].CommandMethod();
  }
}
