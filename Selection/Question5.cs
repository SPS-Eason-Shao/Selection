using System;
namespace Selection
{
	public class Question5 // Q5 Rock, Paper, Scissors
    {
		public Question5()
		{
            foreach (int _ in Enumerable.Range(0, 3))
            {
                RockPaperScissors();
                Console.ReadLine();
            }
        }

        enum RockPaperScissorsChoices // enum for the possible choices
        {
            Rock,
            Paper,
            Scissors
        }

        static void RockPaperScissors() // Function for Q5
        {
            Console.WriteLine("Please input one of: Rock, Paper, Scissors.");

            RockPaperScissorsChoices userChoice;
            while (!Enum.TryParse(Console.ReadLine(), true, out userChoice))
            {
                Console.WriteLine("Input is not valid. Please input one of: Rock, Paper, Scissors.");
            }

            RockPaperScissorsChoices computerChoice = (RockPaperScissorsChoices) new Random().Next(0, 3); // Exclusive upper bound, made a mistake here!
                                                                                                          // Wondered why the computer is not outputing scissors

            Console.WriteLine($"The computer chooses: {computerChoice}.");

            if (userChoice == computerChoice)
            {
                Console.WriteLine("Draw.");
            }
            else if (
                (userChoice == RockPaperScissorsChoices.Rock && computerChoice == RockPaperScissorsChoices.Paper) ||
                (userChoice == RockPaperScissorsChoices.Paper && computerChoice == RockPaperScissorsChoices.Scissors) ||
                (userChoice == RockPaperScissorsChoices.Scissors && computerChoice == RockPaperScissorsChoices.Rock))
            {
                Console.WriteLine("The computer wins!");
            }
            else
            {
                Console.WriteLine("The user wins!");
            }
        }
    }
}

