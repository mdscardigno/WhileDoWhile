using System;

namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# While Do While - Countdown");
            int countdown = 10;
            while (countdown > 0)
            {
                if (countdown == 4)
                {
                    countdown--;//we have to substract 1 or otherwise we will be stock in an infinite loop as the value of 4 does not change
                    continue;
                }
                System.Console.WriteLine("[ " + countdown + "]");
                countdown--;
            }
            Console.WriteLine("🚀 BLAST OFF!!!! 🚀");
            Console.ReadKey();
        }

    }
}
