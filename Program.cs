using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            try
            {
                
                {
                    FizzBuzz fizBuzz = new FizzBuzz();
                    

                    Console.WriteLine("Witaj użytkowniku - Podaj Liczbę");
                    var number = int.Parse(Console.ReadLine());
                    var result = fizBuzz.Game(number);
                    Console.WriteLine(result);



                }
            }
            catch (Exception)
            {

                Console.WriteLine("Podałeś błędne dane");
            }
            finally
            {
                Console.ReadLine();
            }
                

                       


        }
    }
}
