using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zodziai = new string[6] {
                        "labas", "Tomas", "MIN", "labas", " Mantas", "Tomas"};

            for (int i = 0; i < zodziai.Length-1; i++)
            {
                string zodis = zodziai[i];
                
           
                for (int j = i+1; j < zodziai.Length; j++)
                {
                    if (zodis==zodziai[j])
                    {
                        zodziai[j] = string.Empty;
                    }
                }
            }
            

        }
    }
}
