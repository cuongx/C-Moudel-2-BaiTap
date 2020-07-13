using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BaitapDemo
{
    class Forum
    {

        public SortedList<int, Post> Posts = new SortedList<int, Post>();
        public Forum()
        {
            Posts = new SortedList<int, Post>();
        }
        public void Add(Post post)
        {

            Posts.Add(post.Id, post);
            Console.WriteLine("Add Succces");
        }
        public void Update(int id, string content)
        {
            int index = Check(id);
            if (index != -1)
            {
                ((Post)(Posts[index])).Content = content;
                Console.WriteLine("Update Success");
            }
            else
            {
                Console.WriteLine("Không tìm thấy");
            }
        }
        public void Remove(int id)
        {
            int index = Check(id);
            if (index != -1)
            {
                Posts.Remove(index);
                Console.WriteLine("Remove Success");
            }
            else
            {
                Console.WriteLine("Không tìm thấy");
            }

        }
        public void Show()
        {

            for (int i = 0; i < Posts.Count; i++)
            {
                Console.WriteLine(Posts[i].Display());
            }

        }
        public void Search(string id)
        {
            bool result = false;
            for (int i = 0; i < Posts.Count; i++)
            {
                if (Posts[i].Author.Contains(id) || Posts[i].Title.Contains(id))
                {
                    Console.WriteLine(Posts[i].Display());
                    result = true;
                }
                if (!result)
                {
                    Console.WriteLine("Not Found");
                }
            }

        }
        public void Raiting(int id, int rate)
        {
            int index = Check(id);
            do
            {

                if (index != -1)
                {
                    Posts[index].Rates.Add(rate);
                    Posts[index].CaculatorRate();
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Không tìm thấy");
                }

            }
            while (rate < 0 && rate > 5);
         
           
        }
        private int Check(int id)
        {
            foreach(Post iteam in Posts.Values)
            {
                if (iteam.Id.Equals(id))
                {
                    return Posts.IndexOfKey(id);
                }
            }
            return -1;
        }

    }
}

