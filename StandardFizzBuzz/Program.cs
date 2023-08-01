using System;
using TwistedFizzBuzz;

class Program
{
    static void Main()
    {
        // This is the Standar FizzBuzz problem
        int start = 1;
        int end = 100;

        string fizzBuzzOutput1 = TwistedFizzBuzzGenerator.StandarFizzBuzz(start, end);
        Console.WriteLine(fizzBuzzOutput1);
    }
}