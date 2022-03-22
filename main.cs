using System;

class Program {
  public static void Main (string[] args) {
    //https://www.w3resource.com/csharp-exercises/basic-algo/index.php
    //computes the sum of the two given integer values. If the two values are the same, then return triple their sum
    Console.WriteLine("Triple the sum if numbers are the same");
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

    //get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.
    Console.WriteLine("\nGet the absolute difference between entered number and 51");
    Console.Write("Enter number: ");
    int n = int.Parse(Console.ReadLine());
    int difference = n - 51;
    if(n > 51)
    {
      difference= difference *3;
      Console.WriteLine(difference);
    }
    else{
      Console.WriteLine(difference);
    }
    
    //check two given integers, and return true if one of them is 30 or if their sum is 30.
    Console.WriteLine("\nCheck input numbers and return true if one is 30 or if sum is 30");
    Console.Write("Enter first number: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int y = int.Parse(Console.ReadLine());
    if(x == 30 || y == 30)
      Console.WriteLine(true);
    if((x+y)==30)
      Console.WriteLine(true);
    else
      Console.WriteLine(false);
    
  }
  
}