using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFilteredAuthor();
        }

        private static void GetFilteredAuthor()
        {
            Author author1 = new Author();
            author1.Name = "Rasul";
            author1.Surname = "Hasanov";
            author1.Age = 15;
            Author author2 = new Author();
            author2.Name = "Eli";
            author2.Surname = "Veliyev";
            author2.Age = 47;

            List<Author> authors = new List<Author>();

            authors.Add(author1);
            authors.Add(author2);

            var result = authors.FindAll(m => m.Age > 40);

            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
        }
    }
}