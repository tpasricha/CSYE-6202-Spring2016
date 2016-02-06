using System;

namespace FizzBuzz
{
	class Program

    { static void Main(string[] args)
      {
            FizzBuzz fs = new FizzBuzz();
           string result = fs.RunFizzBuzz(98);
            Console.Write(result);
            // Console.ReadKey();
            Console.ReadLine();
      }
	}
}
