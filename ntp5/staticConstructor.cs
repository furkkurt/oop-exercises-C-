using System;

class Player{
  static int total;

  Player(){
    total++;
    Console.WriteLine("Total players: " + total);
  }

  static Player(){
    Console.WriteLine("Welcome!");
  }

  ~Player(){
    total--;
    Console.WriteLine("A player left...");
  }

  static void Main(){
    Player ahmet = new Player();
    Player osman = new Player();
    Player hasan = new Player();
  }
}
