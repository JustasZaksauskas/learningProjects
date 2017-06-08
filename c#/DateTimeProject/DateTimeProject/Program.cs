using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atspausdinti kokia diena bus rytoj
            //var today = DateTime.Today;
            //var tommorow = today.AddDays(1);
            //Console.WriteLine(tommorow.DayOfWeek);
            //Console.WriteLine(DateTime.Today.AddDays(1).DayOfWeek);

            //Atsapausdinti laika po 4 val
            //Console.WriteLine(DateTime.Now.AddHours(4).ToLocalTime());
            //Console.WriteLine(DateTime.UtcNow.ToLocalTime());
            //Console.ReadLine();

            //Atspausdint kokia diena buvo pries 4 dienas
            //Console.WriteLine(DateTime.Today.AddDays(-4).DayOfWeek);
            //Console.ReadLine();

            var data = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(data.ToShortDateString());
            Console.WriteLine(data.ToLongDateString());
            Console.WriteLine(string.Format($"{data.Year}-{data.Month}-{data.Day}"));
            Console.WriteLine(data.ToString("yyyy M d"));
            Console.ReadLine();

        }
    }
}
