using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerdoWhile2inclas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int acum = 0;
            int i = 0;
            

                do
                {
                    
                    acum += i;
                    i++;
                    
                    
                }
                while (i<= 100);

                {
                    Console.WriteLine(acum);
                }
                Console.ReadKey();
            
        }
    }
}