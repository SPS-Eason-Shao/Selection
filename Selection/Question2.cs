using System;
namespace Selection
{
	public class Question2 // Q2 Vowel or Consonant
    {
        public Question2()
		{
            Random random = new();

            char[] testArrayQuestionTwo = { 'a', 'E', 'b', // True, True, False
                (char) random.Next(65, 91), (char) random.Next(65, 91), (char) random.Next(65, 91), // Capitals
                (char) random.Next(97, 123), (char) random.Next(97, 123), (char) random.Next(97, 123) }; // Lower-Case

            foreach (char c in testArrayQuestionTwo)
            {
                Console.WriteLine($"IsVowel('{c}') = {IsVowel(c)}");
            }
        }

        enum LetterTypes // enum for all the possible types of letters
        {
            Vowel,
            Consonant,
            None
        }

        static bool IsVowel(char character) // Returning boolean as stated in the question
        {
            return VowelOrConsonant(character) == LetterTypes.Vowel;
        }

        static LetterTypes VowelOrConsonant(char character) // Function for Q2, returns an enum (which also provides chance for further implementation, if necessary)
        {
            if (!Char.IsLetter(character))
            {
                return LetterTypes.None;
            }

            character = Char.ToLower(character);
            switch (character)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return LetterTypes.Vowel;
                default:
                    return LetterTypes.Consonant;
            }
        }
    }
}

