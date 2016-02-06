using System;

namespace FizzBuzz
{
	class Program

    { static void Main(string[] args)
      {
            FizzBuzz fb = new FizzBuzz();
              string result = fb.RunFizzBuzz(0);
        //    string result = fb.RunFizzBuzz(3);
        //    string result = fb.RunFizzBuzz(5);
        //    string result = fb.RunFizzBuzz(15);
             Console.Write(result);
            // Console.ReadKey();
            Console.ReadLine();
      }
	}
}
