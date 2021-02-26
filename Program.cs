using System;

namespace projectMTN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter short code: ");
            string code = Console.ReadLine();
            if (code == "*170#")
            {
                Console.WriteLine("Menu \n 1) Momo transfer \n 2) Airtime and Bundle '  \n 3) Check ballance");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("1) Momo User \n 2) Other Networks \n 3) MomoPay");
            }
            else if (number == 2)
            {
                Console.WriteLine("1) Self 2)Others");
            }
            else if (number == 3)
            {
                Console.WriteLine("Enter MOMO pin");
            }
            else
            {
                Console.WriteLine("Invalid input. please try again");
            }
        
        }
    }
}
