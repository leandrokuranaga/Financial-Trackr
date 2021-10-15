using System;
using System.Collections.Generic;

namespace Financial_Trackr
{
    public class Operations
    {
        Outgoing outgoing = new();

        public void ConsultSpending()
        {
            //List totalSpending = new();

            for (int i = 0; i <= outgoing.totalSpending.Count; i += 2)
            {
                var spends = outgoing.totalSpending[i];
                Console.WriteLine(spends);
                var numCat = outgoing.category[i];
                Console.WriteLine(numCat);
            }

            //return totalSpending;
        }

        public double ConsultIncoming()
        {
            Incoming incoming = new();
            double totalIncoming = 0;

            foreach (double salary in incoming.amount)
            {
                totalIncoming += salary;
            }

            return totalIncoming;
        }

        //public double ConsultBalance()
        //{
        //    Balance balance = new();

        //    return balance.Money = ConsultIncoming() - ConsultSpending();
        //}

        public void AddSpending()
        {
            int op;

            do
            {
                Console.WriteLine("Do you wanna add money to the outgoing list?\n[1] - Yes\n[2] - No");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Type the amount you wanna add to the outgoing list");
                        double money = double.Parse(Console.ReadLine());
                        outgoing.spending.Add(money);
                        Console.WriteLine("Which category is it?\n[1] - Health\n[2] - Food\n[3] - Education\n[4] - Culture and leisure\n[5] - Games\n[6] - Others");
                        int cat = int.Parse(Console.ReadLine());
                        outgoing.category.Add(cat);
                        break;
                }
            } while (op != 2);
        }


    }
}
