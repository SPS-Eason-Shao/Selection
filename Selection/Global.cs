using System;
namespace Selection
{
	public class Global
	{
        public static int NumberOfSame(double numOne, double numTwo, double numThree) // An function dedicated to return how many are the same.
                                                                                      // This will also be used in the triangle question.
        {
            if (numOne == numTwo && numTwo == numThree)
            {
                return 3;
            }
            else if (numOne == numTwo || numOne == numThree || numTwo == numThree)
            {
                return 2;
            }
            return 1;
        }
	}
}

