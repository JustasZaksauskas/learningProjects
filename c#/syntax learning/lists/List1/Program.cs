using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list;
            list = GetList();
            //indexof
            var index = list.IndexOf(1);
            Console.WriteLine("index of 1: " + index);
            //count
            var count = list.Count;
            Console.WriteLine("count is " + count);
            //remove
            list.Remove(1);
            Console.WriteLine("neturi buti skaiciaus 1  ");
            PrintList(list);

            //insert
            list.Insert(0, 2);
            PrintList(list);

            //sort
            list.Sort();
            PrintList(list);

            //concat
            //list = GetList();
            //var list2 = GetList();

            //var list3= list.Concat(list2);
            //PrintList(list3.ToList());





            Console.ReadLine();
        }
        private static List<int> GetList() {
            var list= new List<int> { 1, 2, 3, 5, 4 };
            return list;
        }

        private static void PrintList(List<int> list) {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
