using System;
namespace Selection
{
	public class Question3 // Q3 Dice Roller
    {
		public Question3()
		{
            foreach (int _ in Enumerable.Range(0, 3))
            {
                Console.WriteLine(DiceRoller());
            }
        }

        static string DiceRoller()
        {
            Random random = new();
            int diceOne = random.Next(1, 7), diceTwo = random.Next(1, 7), diceThree = random.Next(1, 7);
            Console.WriteLine($"The dice are: {diceOne}, {diceTwo} and {diceThree}.");

            switch (Global.NumberOfSame(diceOne, diceTwo, diceThree))
            {
                case 3:
                    return "Three of a kind";
                case 2:
                    return "You have a pair!";
                default:
                    return "Sorry you lose";
            }
        }
    }
}

