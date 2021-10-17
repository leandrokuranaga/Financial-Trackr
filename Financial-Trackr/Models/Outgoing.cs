using System.Collections.Generic;

namespace Financial_Trackr
{
    public class Outgoing
    {
        public double spending { get; set; }
        public List<double> totalSpending { get; set; } = new();
        public List<string> category { get; set; } = new();

        public Outgoing()
        {
        }


    }
}
