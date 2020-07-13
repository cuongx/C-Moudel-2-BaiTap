using System;
using System.Collections.Generic;
using System.Text;

namespace Testbaitap
{
    class Post : IPost
    {
        public int id { get; set; }
        public string Title;
        public string Content;
        public string Author;
        public float AverageRate { get; private set; }

       public List<int> Rate = new List<int>(0);

        public string Display()
        {
            return " ID " + id + " Title " + Title + " Content " + Content+  " Author " + Author + " AverageRate " + AverageRate;  
        }
        public void CalculatorRate()
        {
            float total = 0;
            if (Rate.Count > 0)
            {
              for(int i = 0; i < Rate.Count; i++)
                {
                    total += (float)Rate[i];
                   
                }
                AverageRate = total / Rate.Count;
            }
            else
            {
                AverageRate = 0;
            }
           
        }
    }
}
