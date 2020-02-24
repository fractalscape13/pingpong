using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Please enter a whole number");
    string userInput = Console.ReadLine();
    int inputNum = int.Parse(userInput);
    for (int i = 1; i <= inputNum; i++)
    {
      if (i % 3 == 0 && i % 5 != 0)
      {
        Console.WriteLine("ping");
      }
      else if (i % 3 != 0 && i % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("ping-pong");
      }
      else 
      {
      Console.WriteLine(i);
      }
    }
  }
}