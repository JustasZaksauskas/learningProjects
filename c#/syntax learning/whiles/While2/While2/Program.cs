using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                
     
                int sum = 0;
                while (sum < 50)
                {
                    Console.WriteLine("Iveski skaiciu");
                    var skaicius = Convert.ToInt32(Console.ReadLine());

                    sum +=skaicius;
                    
                    
                }

                Console.WriteLine($"suma didesne uz 50");
                Console.ReadLine();
            }
        }
    }
 