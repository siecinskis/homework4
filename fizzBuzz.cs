using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class FizzBuzz
    {
        public string Game(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
            {
                return "FIZZ BUZZ";
            }
            else if (number % 3 == 0)
            {
                return "FIZZ";
            }
            else if (number % 5 == 0)
            {
                return "BUZZ";
            }
            else 

            {
                return number.ToString();
            }
            
        }
    }
}
