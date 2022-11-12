using Collections.Models;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetFilteredAuthor();

            #region Homework-Practice
            //DateTime startDate = DateTime.Now.AddDays(-5);
            //DateTime endDate = DateTime.Now.AddDays(25);

            //double salary = 2000;

            //IEmployeeService employeeService = new EmployeeService();

            //int result = employeeService.GetFilteredEmployeeCount(startDate, endDate, salary);
            //Console.WriteLine(result);
            #endregion

            #region List-Practice
            //List<int> numbers2 = new List<int>() { 150, 200, 250, 300 };

            //List<int> numbers1 = new List<int>();

            //numbers1.Add(35);
            //numbers1.Add(54);
            //numbers1.Add(18);
            //numbers1.Add(28);
            //numbers1.Add(74);
            //numbers1.Add(90);
            //numbers1.Add(152);
            //numbers1.Add(121);

            //numbers1.AddRange(numbers2);

            //foreach (var item in numbers1)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = numbers1.BinarySearch(28);

            //Console.WriteLine(result);

            //var result = numbers1.FindIndex(m => m > 100);

            //var result = numbers1.FindLastIndex(m => m > 100);

            //var result = numbers1.FindLast(m => m > 100);

            //Console.WriteLine(result);

            //numbers1.Sort();

            //var result = numbers1.ToArray();

            //var result2 = result.ToList();

            //foreach (var item in numbers1)
            //{
            //    Console.WriteLine(item);
            //}


            //var result = numbers1.Contains(18);

            //Console.WriteLine(result);

            //var result = numbers1.Find(m => m > 30);

            //Console.WriteLine(result);

            //var result = numbers1.FindAll(m => m > 30);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in numbers1)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < numbers1.Count; i++)
            //{
            //    Console.WriteLine(numbers1[i]);
            //}

            //List<string> names = new List<string>() { "Rasul", "Novrasta", "Lale", "Nicat" };

            //var result = names.FindAll(m => m == "Rasul");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var searchText = Console.ReadLine();

            //var result = Search(names, searchText);

            //if (result.Count == 0)
            //{
            //    Console.WriteLine("Not Found");
            //}
            //else
            //{
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Console.WriteLine(result.Count);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Person> people = new List<Person>();

            //people.Add(new Person { FullName = "Rasul Hasanov", Birthday = DateTime.Now.AddDays(25), Salary = 5000 });
            //people.Add(new Person { FullName = "Eli Ebilhesenli", Birthday = DateTime.Now.AddDays(-15), Salary = 3500 });
            //people.Add(new Person { FullName = "Qoshqar Narimanli", Birthday = DateTime.Now.AddDays(50), Salary = 5500 });

            //var result = people.FindAll(m => m.Salary > 4000);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Fullname: {item.FullName} Birthday: {item.Birthday} Salary: {item.Salary}");
            //}
            #endregion

            //Hashtable hashtable = new Hashtable();

            //hashtable.Add(1, "Resul");
            //hashtable.Add(2, "Eli");
            //hashtable.Add(3, "Veli");

            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //SortedList sortedList = new SortedList();

            //sortedList.Add(1, "Resul");
            //sortedList.Add(2, "Eli");
            //sortedList.Add(3, "Veli");

            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //ArrayList arrayList = new ArrayList();

            //arrayList.Add("salam");
            //arrayList.Add(155);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedList<int, string> sortedList = new SortedList<int, string>();

            //sortedList.Add(1, "Rasul");
            //sortedList.Add(2, "Qoshqar");
            //sortedList.Add(3, "Ramil");

            //foreach (KeyValuePair<int, string> item in sortedList)
            //{
            //    if (item.Key == 1)
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}

            //Dictionary<int, string> dictionaryList = new Dictionary<int, string>();

            //dictionaryList.Add(1, "Super Admin");
            //dictionaryList.Add(2, "Admin");
            //dictionaryList.Add(3, "Member");

            ////Console.WriteLine(dictionaryList[1]);

            //foreach (KeyValuePair<int, string> item in dictionaryList)
            //{
            //    if (item.Key == 1)
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(5);
            //queue.Enqueue(3);
            //queue.Enqueue(7);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> stack = new Stack<int>();

            //stack.Push(11);
            //stack.Push(5);
            //stack.Push(7);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
        }

        private static List<string> Search(List<string> datas, string str)
        {
            var result = datas.FindAll(m => m.ToLower().Contains(str.ToLower()));
            return result;
        }

        #region Homework-Task
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
        #endregion

    }
}