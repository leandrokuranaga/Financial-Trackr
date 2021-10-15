using System.Collections.Generic;

namespace Financial_Trackr
{
    public class Outgoing
    {
        public double spending { get; set; }
        public List<double> totalSpending { get; set; } = new();
        public List<int> category { get; set; } = new();
        public Dictionary<int, string> categoryTypes { get; set; } = new();

        public Outgoing()
        {
            categoryTypes.Add(1, "Health");
            categoryTypes.Add(2, "Food");
            categoryTypes.Add(3, "Education");
            categoryTypes.Add(4, "Culture and leisure");
            categoryTypes.Add(5, "Games");
            categoryTypes.Add(6, "Others");
        }


    }
}
