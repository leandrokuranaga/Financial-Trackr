using System;
using System.Collections.Generic;
using System.Linq;

namespace Financial_Trackr
{
    public class Operations
    {
        Outgoing outgoing = new();
        Incoming incoming = new();
        Balance balance = new();

        public double ConsultSpending()
        {
            double totalSpending = outgoing.totalSpending.Sum();

            return totalSpending;
        }

        public double ConsultIncoming()
        {
            double totalIncoming = incoming.amount.Sum();

            return totalIncoming;
        }

        public double ConsultBalance()
        {
            return balance.Money = ConsultIncoming() - ConsultSpending();
        }

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
                        outgoing.totalSpending.Add(money);
                        Console.WriteLine("Which category is it?\n[1] - Health\n[2] - Food\n[3] - Education\n[4] - Culture and leisure\n[5] - Games\n[6] - Others");
                        int cat = int.Parse(Console.ReadLine());
                        switch (cat)
                        {
                            case 1:
                                outgoing.category.Add("Health");
                                break;
                            case 2:
                                outgoing.category.Add("Food");
                                break;
                            case 3:
                                outgoing.category.Add("Education");
                                break;
                            case 4:
                                outgoing.category.Add("Culture and Leisure");
                                break;
                            case 5:
                                outgoing.category.Add("Games");
                                break;
                            case 6:
                                outgoing.category.Add("Others");
                                break;
                        }
                        break;
                }
            } while (op != 2);
        }
 
        public void Historic()
        {
            for(int i = 0; i < outgoing.totalSpending.Count; i++)
            {
                Console.WriteLine("{0}: {1}", outgoing.category[i], outgoing.totalSpending[i]);
            }
        }

    }
}
