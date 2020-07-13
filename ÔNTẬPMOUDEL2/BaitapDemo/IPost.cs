using System;
using System.Collections.Generic;
using System.Text;

namespace BaitapDemo
{
    interface IPost
    {
        public string Display();
        public void CaculatorRate();
    }
   public class Post : IPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public float AverageRate { get; private set; }

      public Post() { }

        public  List<int> Rates = new List<int>();
      
         public string Display()
        {
            return
             "ID " + Id + "\t" +
                "Title " + Title + "\t" +
                "Content " + Content + "\t" +
                "Author " + Author + "" + "\t" +
                "AverageRate " + AverageRate + "\t";
               
        }
       public void CaculatorRate()
        {
            float sum = 0;
            if (Rates.Count > 0)
            {
                for (int i = 0; i < Rates.Count; i++)
                {
                    sum += (float)Rates[i];
                   
                }
                AverageRate = sum / Rates.Count;
            }
            else
            {
                AverageRate = 0;
            }
         
        }
    }
}
