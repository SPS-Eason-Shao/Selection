using System;
namespace Selection
{
	public class Question7 // Q7 18 to 30 holiday
    {
		public Question7()
		{
            DateTime[] testArrayQuestionSeven = { new DateTime(2007, 11, 18), new DateTime(1980, 11, 29), new DateTime(2000, 01, 08),
            // boundry test examples
            DateTime.Today.AddYears(-18).AddDays(-1), // 17yo, false
            DateTime.Today.AddYears(-18), // 18yo, true
            DateTime.Today.AddYears(-18).AddDays(1), // 18yo, true
            DateTime.Today.AddYears(-31).AddDays(-1), // 30yo, true
            DateTime.Today.AddYears(-31), // 31yo, false
            DateTime.Today.AddYears(-31).AddDays(1) }; // 31yo, false

            foreach (DateTime d in testArrayQuestionSeven)
            {
                Console.WriteLine($"IsEligible( new DateTime ({d.Year}, {d.Month}, {d.Day}) ) = {IsEligible(d)}");
            }
        }

        static bool IsEligible(DateTime bornDate)
        {
            int age = DateTime.Today.Year - bornDate.Year;

            if (DateTime.Today > bornDate.AddYears(age)) // birthday not yet reached
            {
                --age;
            }

            if (18 <= age && age <= 30)
            {
                return true;
            }

            return false;
        }
    }
}

