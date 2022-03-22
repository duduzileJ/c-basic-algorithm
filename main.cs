using System;

class Program {
  public static void Main (string[] args) {
    //https://www.w3resource.com/csharp-exercises/basic-algo/index.php
    //computes the sum of the two given integer values. If the two values are the same, then return triple their sum
    Console.WriteLine("Triple the sum");
    Console.Write("Enter first number: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int num2 = int.Parse(Console.ReadLine());
    int sum;
    if(num1 == num2)
    {
      sum = (num1 + num2)*3;
      Console.WriteLine(sum);
    }
    else
    {
      sum = num1 + num2;
      Console.WriteLine(sum);
    }
    
    
    
  }
}