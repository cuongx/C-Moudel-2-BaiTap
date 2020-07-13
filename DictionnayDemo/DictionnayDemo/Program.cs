using System;
using System.Collections.Generic;

namespace DictionnayDemo
{
    class Book
    {
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Book> bookList = new Dictionary<string, Book>();

            //Thêm phần tử
            bookList.Add("9780321344755", new Book { ISBN = "9780321344755", Name = "Don't Make Me Think (Beta)", Author = "Steve Krug" });
            bookList.Add("1491904909", new Book { ISBN = "1491904909", Name = "User Story Mapping", Author = "Jeff Patton" });
            bookList.Add("9780465050659", new Book { ISBN = "9780465050659", Name = "The Design of Everyday Things", Author = "Don Norman" });
            Console.WriteLine("Add books to Dictionary");
            PrintValue(bookList);


            //Sửa phần tử
            bookList["9780321344755"] = new Book { ISBN = "9780321344755", Name = "Don't Make Me Think", Author = "Steve Krug" };
            Console.WriteLine("Edit book with ISBN");
            PrintValue(bookList);


            //Tìm kiếm phần tử
            Console.WriteLine("Search for a specific book with ISBN");

            if (bookList.ContainsKey("9780321344755") == false)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Book book = bookList["9780321344755"];
                Console.WriteLine("Found this book: " + book.Name);
            }

            Console.WriteLine();


            //Xoá phần tử
            bookList.Remove("9780321344755");
            Console.WriteLine("Remove book with ISBN");
            PrintValue(bookList);
        }


        static void PrintValue(Dictionary<string, Book> books)
        {
            foreach (KeyValuePair<string, Book> kvp in books)
            {
                Book book = kvp.Value;

                Console.WriteLine("ISBN: " + book.ISBN + " - " +
                    book.Name + " - " + book.Author);
            }
            Console.WriteLine();
        }

    }
}
    

