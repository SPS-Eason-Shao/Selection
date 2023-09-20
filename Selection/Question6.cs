using System;
namespace Selection
{
	public class Question6 // Q6 Triangle
    {
		public Question6()
		{
            Random random = new();

            (double, double, double)[] testArrayQuestionSix = { (1, 3, 3), (3, 3, 3), (3, 4, 5), // Isosceles, Equilateral, Scalene
            (random.Next() / 100.0, random.Next() / 100.0, random.Next() / 100.0),
            (random.Next() / 100.0, random.Next() / 100.0, random.Next() / 100.0),
            (random.Next() / 100.0, random.Next() / 100.0, random.Next() / 100.0) };

            foreach ((double i, double j, double k) in testArrayQuestionSix)
            {
                Console.WriteLine($"Triangles({i}, {j}, {k}) = {Triangles(i, j, k)}");
            }

        }

        enum TriangleTypes // enum for possible triangle types
        {
            None,
            Scalene,
            Isosceles,
            Equilateral
        }

        static TriangleTypes Triangles(double sideOne, double sideTwo, double sideThree) // function for determining types of triangles
        {
            return (TriangleTypes) Global.NumberOfSame(sideOne, sideTwo, sideThree);
        }
    }
}

