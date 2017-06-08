using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zodziai = new string[6] {
                        "labas", "Tomas", "MIN", "labas", " Mantas", "Tomas"};

            Array.Sort(zodziai);

            for (int i = 0; i < zodziai.Length - 1; i++)
            {

                if (zodziai[i] == zodziai[i + 1])
                {
                    zodziai[i] = string.Empty;
                }
            }


            for (int i = 0; i < zodziai.Length; i++)
                Console.WriteLine(zodziai[i]);

            {

                Console.ReadLine();

                //    for (int j = i + 1; j < zodziai.Length; j++)
                //    {
                //        if (zodis == zodziai[j])
                //        {
                //            zodziai[j] = string.Empty;
                //        }
                //    }
                //}


            }
        }
    }
}
