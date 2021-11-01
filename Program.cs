using System;

namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# While Do While - Countdown");
            // int countdown = 10;
            // while (countdown > 0)
            // {
            //     if (countdown == 4)
            //     {
            //         countdown--;//we have to substract 1 or otherwise we will be stock in an infinite loop as the value of 4 does not change
            //         continue;
            //     }
            //     System.Console.WriteLine("[ " + countdown + "]");
            //     countdown--;
            // }
            // Console.WriteLine("🚀 BLAST OFF!!!! 🚀");

            //***********EXAMPLE WITH WHILE AND DO WHILE************
            // string response;
            // do
            // {
            //     System.Console.WriteLine("Please Enter YES or NO");
            //     response = Console.ReadLine();
            // } while (response != "YES" && response != "NO");

            // if (response == "SI")
            // {
            //     System.Console.WriteLine("You have entered " + response);
            // }
            // else
            // {
            //     System.Console.WriteLine("You have entered " + response);
            // }

            int account = 10;
            while (account > 0)
            {
                System.Console.WriteLine(account);
                account--;
            }
            System.Console.WriteLine("Blast off!");

            for (int account2 = 10; account2 > 0; account2--)
            {
                System.Console.WriteLine(account2);
            }
            System.Console.WriteLine("Blast off!");



            Console.ReadKey();
        }

    }
}
