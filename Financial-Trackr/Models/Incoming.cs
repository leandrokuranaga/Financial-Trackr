using System.Collections.Generic;

namespace Financial_Trackr
{
    public class Incoming
    {
        public List<double> amount { get; set; } = new();

        public Incoming()
        {
            amount.Add(1000.00);
            amount.Add(1526.00);
            amount.Add(300.00);
        }

    }
}
