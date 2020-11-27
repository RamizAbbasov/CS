using System;

class Program{

public static void Main(string[] args){
  int balance = 100;
  int count = 0;
  bool loop = true;
      Console.WriteLine("Welcome to our bank program");
      Console.Write("Please enter your name:");
      string name = Convert.ToString(Console.ReadLine());
      Console.Write("Please enter your password:");
      int pass = Convert.ToInt32(Console.ReadLine());

  while (loop)
  {
      if (name != "Ramiz" && pass != 1234)
      {
          count++;
      }
      if (count == 3)
      {
          loop = false;
      }
  }
      //if (name == "Ramiz" && pass == 1234)
      //{
      Console.WriteLine("Welcome back, sir");
      Console.WriteLine("[1]-Deposit\n[2]-Withdraw\n[3]-Account information");
      Console.Write("Choose one option above:");
      int options = Convert.ToInt32(Console.ReadLine());
      if (options == 1)
      {
          Console.Write("Enter the amount that you want to deposit:");
          int deposit = Convert.ToInt32(Console.ReadLine());
          balance += deposit;
          Console.WriteLine("Money you have deposited:" + deposit);
          Console.WriteLine("Your new balance:" + balance);
      }
      else if (options == 2)
      {
          Console.Write("Enter the amount that you want to withdraw:");
          int withdraw = Convert.ToInt32(Console.ReadLine());
          balance -= withdraw;
          Console.WriteLine("Money you have withdrawed:" + withdraw);
          Console.WriteLine("Your new balance:" + balance);
      }
      else if (options == 3)
      {
          Console.WriteLine("Name:" + "Ramiz");
          Console.WriteLine("Surname" + "Abbasov");
          Console.WriteLine("Your password" + "****");
          Console.WriteLine("Your current balance:" + balance);
      }
      }
      //else
      //{
      //Console.WriteLine("Please make sure that you have entered the right credentials");
      //}
}
}
