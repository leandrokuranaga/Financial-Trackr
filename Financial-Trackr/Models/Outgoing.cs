using System.Collections.Generic;

namespace Financial_Trackr
{
    public class Outgoing
    {
        public List<double> spending { get; set; } = new();

        public Outgoing()
        {
            spending.Add(100.00);
            spending.Add(200.00);
            spending.Add(890.00);
            spending.Add(132.90);
        }


    }
}
