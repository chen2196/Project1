using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>responses = new List<int>() { 1, 2, 5, 4, 3, 5, 2, 1, 3, 3, 1, 4, 3, 3, 3, 2, 3, 3, 2, 14 };
            var results = responses.GroupBy(x => x).OrderBy(x=>x.Key);
            foreach(var item in results)
            {
                Console.WriteLine($"{item.Key,4}{item.Count(),10}");
            }
        }
    }
}
