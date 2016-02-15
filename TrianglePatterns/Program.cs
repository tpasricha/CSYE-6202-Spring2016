using System;

namespace TrianglePatterns
{
	class Program
	{
            static void Main(string[] args)
		{
			DisplayPatternA();
			DisplayPatternB();
			DisplayPatternC();
			DisplayPatternD();
         
            Console.ReadLine();
        }

        static void DisplayPatternA()
		{
                for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column <= row; column++)
                     Console.Write("*");
                     Console.WriteLine();
            }

            Console.WriteLine();
		}

		static void DisplayPatternB()
		{
            for (int row = 10; row > 0; row--)
            {
                for (int column = 0; column < row; column++)
                    Console.Write("*");
                    Console.WriteLine();
            }

            Console.WriteLine();
        }

		static void DisplayPatternC()
		{
			for(int row = 0;row<10;row++)
            {
                for(int column=0;column< row; column++)
                    Console.Write(" ");

                for (int column = 0; column < 10 - row; column++)
                    Console.Write("*");
                    Console.WriteLine();             
            }
            Console.WriteLine();
        }

		static void DisplayPatternD()
		{
            for (int row = 10; row >= 0; row--)
            {
                for (int column = 0; column < row; column++)
                    Console.Write(" ");

                for (int column = 0; column < 10 - row; column++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
	}
}
