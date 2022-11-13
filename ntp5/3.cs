using System;

class Program{
  class BankAccount{
    public ulong AccountNo;
  }

  public static void Main(string[] args){
    BankAccount account1 = new BankAccount();
    BankAccount account2 = new BankAccount();
    account1.AccountNo=3456;
    account2.AccountNo=3131;
    Console.WriteLine(account1.AccountNo);
    Console.WriteLine(account2.AccountNo);
  }
}
