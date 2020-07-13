using System;
using System.Collections.Generic;
using System.Text;

namespace Testbaitap
{
    class Forum
    {
       public SortedList<int, Post> Posts = new SortedList<int, Post>();


       public Forum()
        {
          
        }
        public void Add(Post newpost)
        {
            Posts.Add(newpost.id, newpost);
            Console.WriteLine("Ok");
        }
        public void Update(int id ,string content)
        {
            int index = Check(id);
            if(id != -1) {
                Posts[id].Content =content;
                Console.WriteLine("Update Success");
            }
            else
            {
                Console.WriteLine("Not is Complete");
            }
        }
        public void Remove(int id)
        {
            int index = Check(id);
            if (id != -1)
            {
                Posts.Remove(id);
                Console.WriteLine("Remove Success");
            }
            else
            {
                Console.WriteLine("Not is Complete");
            }
        }
        public void Show()
        {

          foreach(Post pb in Posts.Values)
            {
                Console.WriteLine(pb.Display());
            }

         }
        public void Searching(string author)
        {
            bool result = false;

           for(int i = 0; i < Posts.Count; i++)
            {
                if (Posts[i].Author.ToLower().Contains(author) || Posts[i].Title.ToLower().Contains(author))
                   {
                    Console.WriteLine(Posts[i].Display());
                    result = true;
                }
               
            }
            if (!result)
            {
                Console.WriteLine("Not found");
            }
        }
        public void Rate(int id,int rate)
        {
            int index = Check(id);
            if (id != -1)
            {
                Posts[id].Rate.Add(rate);
                Posts[id].CalculatorRate();
                Console.WriteLine("Rate ok ");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public int Check(int Id)
        {
          
            foreach (Post pb in Posts.Values)
            {
                if (pb.id ==Id)
                {
                    return Id;
                }
            }
            return -1;
        }
    }
}
