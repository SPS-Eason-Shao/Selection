using System;
namespace Selection
{
	public class Question4 // Q4 Angles
	{
		public Question4()
		{
            Random random = new();

            double[] testArrayQuestionFour = { 0, 20, 90, 120, 180, 270, 360, // Others, Acute, Right, Obtuse, Straight, Reflex, Others
            random.Next(1, 36001) / 100.00, random.Next(1, 36001) / 100.00, random.Next(1, 36001) / 100.00 };

            foreach (double i in testArrayQuestionFour)
            {
                Console.WriteLine($"Angles({i}) = {Angles(i)}");
            }
        }

        enum AngleTypes // enum for all possible types of angles, including others (which is less than 0 or more than 180)
        {
            Acute,
            RightAngle,
            Obtuse,
            Straight,
            Reflex,
            Others
        }

        static AngleTypes Angles(double angle) // Function for Q4
        {
            switch (angle)
            {
                case > 0 and < 90:
                    return AngleTypes.Acute;
                case 90:
                    return AngleTypes.RightAngle;
                case > 90 and < 180:
                    return AngleTypes.Obtuse;
                case 180:
                    return AngleTypes.Straight;
                case > 180 and < 360:
                    return AngleTypes.Reflex;
                default:
                    return AngleTypes.Others;
            }
        }
    }
}

