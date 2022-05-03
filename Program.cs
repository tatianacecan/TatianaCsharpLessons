using System;
using System.Collections.Generic;
using System.Linq;

namespace collect
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic collections


            // List<T>

           IList<int> list = new List<int>();
            list.Add(11);
            list.Add(22);
            list.Add(33);
            list.Add(44);
            list.Add(55);
            Console.WriteLine(list.Contains(22));
            Console.WriteLine(list.Contains(10));
            Console.WriteLine(list.IndexOf(55));
            list.Remove(11);
            list.RemoveAt(1);
            Console.WriteLine(string.Join(",", list));

            var num = new List<int> { 34, 1, 3, 5, 8, 54 };
            num.Sort();
            Console.WriteLine(string.Join(",", num));

            num.Reverse();
            Console.WriteLine(string.Join(",", num));

            // HashSet<T>

            ISet<double> set = new HashSet<double>() { 1.3, 5.2, 9.2, 3.1, 6.3};
            set.Contains(1.3);
            set.Equals(9.2);
            Console.WriteLine(set.GetType());
            set.Remove(5.2);
            Console.WriteLine(set.Sum());
            Console.WriteLine(set.Average());
            Console.WriteLine(set.Min());


            //Dictionary<Tkey, Tvalue>

            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Ana");
            dict.Add(2, "Andrei");
            dict.Add(3, "Ion");
            dict.Add(5, "Elena");
            Console.WriteLine(dict.ContainsKey(2));
            Console.WriteLine(dict.Remove(3));
           

        }
    }
}
