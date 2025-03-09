using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace LeaningApp.LINQ
{
    class LinqQuryExamples
    {
        static LinqQuryExamples linqQuryExamples;
        LinqQuryExamples()
        {

        }
        internal static LinqQuryExamples GetInstance()
        {
            return linqQuryExamples = linqQuryExamples ?? new LinqQuryExamples();
        }

        internal void PrintEvennumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = from number in numbers where number % 2 == 0 select number;
            Console.WriteLine($"EvenNumbers:{JoinValues<int>(evenNumbers)}");
        }
        internal void PrintJoin2Sequences()
        {
            int[] numbers = { 1, 3, 8, 4, 6, 6, 8, 8, 6, 10 };
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var joinedNumber = from number in numbers 
                              join number2 in numbers2 on  number equals number2
                              where number > 5
                              orderby number2 descending
                              select  $"{number}-{number2}";


            Console.WriteLine($"Join2Sequences:{JoinValues<string>(joinedNumber)}");
        }

        /// <summary>
        /// Let Keyword: Allows you to store the result of a subquery in a variable to reuse it within the same query.
        /// </summary>
        internal void LinqLet()
        {
            int[] numbers = { 1, 3, 8, 4, 6, 6, 8, 8, 6, 10 };
            var resut = from number in numbers 
                        let squeare=number*number
                 where squeare > 30
                        select $"[Numer:{number}-Square:{squeare}]";

            Console.WriteLine($"{JoinValues<string>(resut)}");
        }

        /// <summary>
        /// GroupJoin: Combines data and groups the results.
        /// </summary>
        internal void LinqGroupJoine()
        {
            //var groupJoin = from c in categories
            //                join p in products on c.Id equals p.CategoryId into productGroup
            //                select new { c.CategoryName, Products = productGroup };
           // Console.WriteLine($"{JoinValues<string>()}");
        }



        string JoinValues<T>(IEnumerable<T> list)
        {
            var sb = new StringBuilder();
            foreach (var val in list)
            {
                sb.Append($"{val},");
            }
            return sb.ToString();

        }
    }
}
