using System;
using BasicsLearning.Models;
class Program
{
    static void Test()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("I am in home");
    }
}

class AnotherClass
{
    void SampleMethod()
    {
        Console.WriteLine("This is another class.");
    }
}

// Write a method to print sum of two numbers
class MathOperations
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public void DisplaySum(int a, int b)
    {
        int result = Sum(a, b);
        Console.WriteLine("The sum of {0} and {1} is: {2}", a, b, result);
    }

    public static void Main(string[] args)
    {
        MathOperations mathOps = new MathOperations();
        Console.WriteLine("Calculating sum of two numbers:");
        Console.Write("Enter first number: ");
        string? input1 = Console.ReadLine();
        int num1 = int.Parse(input1 ?? "0");

        Console.Write("Enter second number: ");
        string? input2 = Console.ReadLine();
        int num2 = int.Parse(input2 ?? "0");

        mathOps.DisplaySum(num1, num2);

        // Using UserModel from BasicsLearning.Models
        UserModel user = new UserModel
        {
            Name = "Alice",
            Age = 30
        };
        user.PrintDetails();
    }
}
