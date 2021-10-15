using System;

namespace Financial_Trackr
{
    class Program
    {
        public static void Main(string[] args)
        {
            Operations operations = new();
            int operation;

            do
            {
                Console.WriteLine("Welcome to the Financial Trackr, please, choose what you'd like to do!");
                Console.WriteLine("[1] - CONSULT SPENDS\n[2] - CONSULT SAVINGS\n[3] - CONSULT BALANCE\n[4] - EXIT");
                operation = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                double result;
                switch (operation)
                {
                    case 1:
                        Console.Clear();
                        result = operations.ConsultSpending();
                        Console.WriteLine("Your Spending is ${0}\n", result);
                        break;

                    case 2:
                        Console.Clear();
                        result = operations.ConsultIncoming();
                        Console.WriteLine("Your Incoming is ${0}\n", result);
                        break;

                    case 3:
                        Console.Clear();
                        result = operations.ConsultBalance();
                        Console.WriteLine("Your current balance is ${0}\n", result);
                        break;
                }

                if (operation == 4)
                    Console.WriteLine("Glad to help! See you soon!");

            } while (operation != 4);

        }
    }
}
