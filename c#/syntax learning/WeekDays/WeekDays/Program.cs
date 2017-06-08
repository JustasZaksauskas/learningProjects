using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekDays
{
    class Program
    {
       public enum Dienos{
            Sekmadienis,
            Pirmadienis,
            Antradienis,
            Treciadienis,
            Ketvirtadienis,
            Penktadienis,
            Sestadienis
        }


        static void Main(string[] args)
        {
            //abuvariantai galimi pavertimui
           var today= DateTime.Today.DayOfWeek;
            var friday = DayOfWeek.Friday;

            var result = friday - today;
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                result = 6;
            }
            Console.WriteLine(today);
            Console.WriteLine(friday);

            Console.WriteLine($"Siandien yra {GetLithuanianDays(today)}, iki penktadienio liko dienu {result}");



            Console.ReadLine();
        }

        public static Dienos GetLithuanianDays(DayOfWeek day) {
            return (Dienos) day;
           
        }

    }
}
