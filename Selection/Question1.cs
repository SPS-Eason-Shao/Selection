using System;
namespace Selection
{
	public class Question1 // Q1 Fizz Buzz
    {
		public Question1()
		{
            Random random = new();

            int[] testArrayQuestionOne = {
                15, // FizzBuzz
                3, // Fizz
                5, // Buzz
                1, // "1"
                random.Next(), random.Next(), random.Next() };

            foreach (int i in testArrayQuestionOne)
            {
                Console.WriteLine($"FizzBuzz({i}) = \"{FizzBuzz(i)}\"");
            }
        }

        static string FizzBuzz(int number) // Function for Q1
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }

    }
}

