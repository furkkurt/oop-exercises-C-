using System;

class Student{
  public ulong studentNum;
  public string name;
  public string surname; 
  public string program;
  public byte Class;
}
class Program{
  static void Main(){
    Student student = new Student();

    Console.WriteLine(student.studentNum);
    Console.WriteLine(student.name);
    Console.WriteLine(student.surname);
    Console.WriteLine(student.program);
    Console.WriteLine(student.Class);
  }
}
