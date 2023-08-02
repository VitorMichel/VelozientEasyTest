using Newtonsoft.Json.Linq;
using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml.Linq;
using TwistedFizzBuzz;

class Program
{
    static async Task Main()
    {
        #region Example 1
        //Example 1: Range of numbers
        Console.Write("Enter the start value: ");
        int startExample1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the end value: ");
        int endExample1 = int.Parse(Console.ReadLine());

        string fizzBuzzOutput1 = TwistedFizzBuzzGenerator.GenerateSequentialOutput(startExample1, endExample1);
        Console.WriteLine(fizzBuzzOutput1);
        #endregion

        #region Example 2
        // Example 2: Non-sequential set of numbers
        List<int> numbers = new();

        Console.Write("Enter the quantity of numbers: ");
        int index = int.Parse(Console.ReadLine());

        for (int i = 1; i <= index; i++)
        {
            Console.Write(string.Format("Number {0}: ", i));
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        string fizzBuzzOutput2 = TwistedFizzBuzzGenerator.GenerateNonSequentialOutput(numbers);
        Console.WriteLine(fizzBuzzOutput2);
        #endregion

        #region Example 3
        // Example 3: Alternative tokens and divisors
        Console.Write("Enter the start value: ");
        int startExample3 = int.Parse(Console.ReadLine());
        Console.Write("Enter the end value: ");
        int endExample3 = int.Parse(Console.ReadLine());
        Console.Write("Enter the first token word value: ");
        string word1 = Console.ReadLine();
        Console.Write("Enter the second token word value: ");
        string word2 = Console.ReadLine();
        Console.Write("Enter the first token word divisor value: ");
        int word1Divisor = int.Parse(Console.ReadLine());
        Console.Write("Enter the second token word divisor value: ");
        int word2Divisor = int.Parse(Console.ReadLine());

        string fizzBuzzOutput3 = TwistedFizzBuzzGenerator.GenerateSequentialOutput(startExample3, endExample3, word1, word2, word1Divisor, word2Divisor);
        Console.WriteLine(fizzBuzzOutput3);
        #endregion

        #region Example 4
        //Example 4: Using API generated tokens
        string apiURL = "https://rich-red-cocoon-veil.cyclic.app/random";
        TwistedFizzBuzzGenerator twistedFizzBuzzGenerator = new();
        string result = await twistedFizzBuzzGenerator.GenerateOutputFromAPI(apiURL);
        Console.WriteLine(result);
        #endregion
    }
}