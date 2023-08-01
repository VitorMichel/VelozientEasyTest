using NUnit.Framework;
using System.Collections.Generic;
using TwistedFizzBuzz;

[TestFixture]
public class TwistedFizzBuzzGeneratorTests
{
    [Test]
    public void TestGenerateSequentialOutput()
    {
        string expectedOutput = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n";

        string output = TwistedFizzBuzzGenerator.GenerateSequentialOutput(1, 15, "Fizz", "Buzz", 3, 5);

        Assert.AreEqual(expectedOutput, output);
    }

    [Test]
    public void TestGenerateNonSequentialOutput()
    {
        string expectedOutput = "Fizz\nBuzz\nFizz\n";

        List<int> numbers = new List<int> { 3, 5, 6 };
        string output = TwistedFizzBuzzGenerator.GenerateNonSequentialOutput(numbers, "Fizz", "Buzz", 3, 5);

        Assert.AreEqual(expectedOutput, output);
    }

    [Test]
    public void TestStandarFizzBuzz()
    {
        string expectedOutput = "1\n2\nFizz\n4\nbuzz\nFizz\n7\n8\nFizz\nbuzz\n11\nFizz\n13\n14\nFizzBuzz\n";

        string output = TwistedFizzBuzzGenerator.StandarFizzBuzz(1, 15);

        Assert.AreEqual(expectedOutput, output);
    }

    [Test]
    public void TestFizzBuzzBarProblem()
    {
        string expectedOutput = "1\n2\nFizz\n4\nbuzz\nFizz\n7\n8\nFizz\nbuzz\n11\nFizz\n13\n14\nFizzBuzz\n16\n17\nFizz\n19\nbuzz\nFizz\n22\n23\nFizz\nbuzz\n26\nFizz\nBar\n";

        string output = TwistedFizzBuzzGenerator.FizzBuzzBarProblem(1, 30);

        Assert.AreEqual(expectedOutput, output);
    }
}