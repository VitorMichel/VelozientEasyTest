using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace TwistedFizzBuzz
{
    public class TwistedFizzBuzzGenerator
    {
        private static readonly string defaultFizzToken = "Fizz";
        private static readonly string defaultBuzzToken = "Buzz";
        private static readonly int defaultFizzDivisor = 3;
        private static readonly int defaultBuzzDivisor = 5;

        public static string GenerateSequentialOutput(int start, int end, string fizzToken = null, string buzzToken = null, int fizzDivisor = 0, int buzzDivisor = 0)
        {
            fizzToken ??= defaultFizzToken;
            buzzToken ??= defaultBuzzToken;
            fizzDivisor = fizzDivisor != 0 ? fizzDivisor : defaultFizzDivisor;
            buzzDivisor = buzzDivisor != 0 ? buzzDivisor : defaultBuzzDivisor;

            if (start > end)
            {
                throw new ArgumentException("Start value cannot be greater than the end value.");
            }

            string output = "";

            for (int i = start; i <= end; i++)
            {
                bool isFizz = i % fizzDivisor == 0;
                bool isBuzz = i % buzzDivisor == 0;

                if (isFizz && isBuzz)
                {
                    output += fizzToken + buzzToken + "\n";
                }
                else if (isFizz)
                {
                    output += fizzToken + "\n";
                }
                else if (isBuzz)
                {
                    output += buzzToken + "\n";
                }
                else
                {
                    output += $"{i}\n";
                }
            }

            return output;
        }

        public static string GenerateNonSequentialOutput(IEnumerable<int> numbers, string fizzToken = null, string buzzToken = null, int fizzDivisor = 0, int buzzDivisor = 0)
        {
            fizzToken ??= defaultFizzToken;
            buzzToken ??= defaultBuzzToken;
            fizzDivisor = fizzDivisor != 0 ? fizzDivisor : defaultFizzDivisor;
            buzzDivisor = buzzDivisor != 0 ? buzzDivisor : defaultBuzzDivisor;

            string output = "";

            foreach (int number in numbers)
            {
                bool isFizz = number % fizzDivisor == 0;
                bool isBuzz = number % buzzDivisor == 0;

                if (isFizz && isBuzz)
                {
                    output += fizzToken + buzzToken + "\n";
                }
                else if (isFizz)
                {
                    output += fizzToken + "\n";
                }
                else if (isBuzz)
                {
                    output += buzzToken + "\n";
                }
                else
                {
                    output += $"{number}\n";
                }
            }

            return output;
        }

        // Method for accepting API generated tokens from a URL
        public async Task GenerateOutputFromAPI(string apiURL)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiURL);

                if (response.IsSuccessStatusCode)
                {
                    //The request was successful, read the content as a string
                    string responseContent = await response.Content.ReadAsStringAsync();

                    dynamic data = JObject.Parse(responseContent);

                    var multiple = data.multiple.Value;
                    var word = data.word.Value;

                    GenerateSequentialOutput(1, 50, word, "", multiple, 0);
                }
                else
                    Console.WriteLine($"Request failed with status code: {response.StatusCode}");
            }
        }

        public static string StandarFizzBuzz(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentException("Start value cannot be greater than the end value.");
            }

            string output = "";

            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    output += "FizzBuzz\n";
                }
                else if (i % 3 == 0)
                {
                    output += "Fizz\n";
                }
                else if (i % 5 == 0)
                {
                    output += "buzz\n";
                }
                else
                {
                    output += $"{i}\n";
                }
            }

            return output;
        }

        public static string FizzBuzzBarProblem(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentException("Start value cannot be greater than the end value.");
            }

            string output = "";

            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    output += "Fizz\n";
                }
                else if (i % 9 == 0)
                {
                    output += "Buzz\n";
                }
                else if (i % 27 == 0)
                {
                    output += "Bar\n";
                }
                else
                {
                    output += $"{i}\n";
                }
            }

            return output;


        }
    }
}