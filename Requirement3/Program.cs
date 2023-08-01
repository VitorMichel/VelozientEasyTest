using System;
using TwistedFizzBuzz;

class Program
{
    static void Main()
    {
        // Output values from -20 to 127
        int start = -20;
        int end = 127;

        string fizzBuzzOutput1 = TwistedFizzBuzzGenerator.FizzBuzzBarProblem(start, end);
        Console.WriteLine(fizzBuzzOutput1);
    }
}