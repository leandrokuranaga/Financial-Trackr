namespace Financial_Trackr
{
    public class Operations
    {

        public double ConsultSpending()
        {
            Outgoing outgoing = new();
            double totalSpending = 0;

            foreach (double x in outgoing.spending)
            {
                totalSpending += x;
            }

            return totalSpending;
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

        public double ConsultBalance()
        {
            Balance balance = new();

            return balance.Money = ConsultIncoming() - ConsultSpending();
        }
    }
}
