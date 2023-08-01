using Newtonsoft.Json.Linq;
using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml.Linq;
using TwistedFizzBuzz;

class Program
{
    static void Main()
    {
        // Example 1: Range of numbers
        int startExample1 = Convert.ToInt32(Console.ReadLine());
        int endExample1 = Convert.ToInt32(Console.ReadLine());
        string fizzBuzzOutput1 = TwistedFizzBuzzGenerator.GenerateSequentialOutput(startExample1, endExample1);
        Console.WriteLine(fizzBuzzOutput1);

        // Example 2: Non-sequential set of numbers
        int[] numbers = { };
        int index = Convert.ToInt32(Console.ReadLine());
        foreach (var i in index)
        {

        }

        string fizzBuzzOutput2 = TwistedFizzBuzzGenerator.GenerateNonSequentialOutput(numbers);
        Console.WriteLine(fizzBuzzOutput2);

        // Example 3: Alternative tokens and divisors
        int startExample3 = Convert.ToInt32(Console.ReadLine());
        int endExample3 = Convert.ToInt32(Console.ReadLine());
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();
        string fizzBuzzOutput3 = TwistedFizzBuzzGenerator.GenerateSequentialOutput(startExample3, endExample3, word1, word2, 7, 17);
        Console.WriteLine(fizzBuzzOutput3);

        //Example 4: Using API generated tokens
        string apiURL = "https://rich-red-cocoon-veil.cyclic.app/random";
        //Task fizzBuzzOutput4 = TwistedFizzBuzzGenerator.GenerateOutputFromAPI(apiURL);
        //Console.WriteLine(fizzBuzzOutput4);
    }
}