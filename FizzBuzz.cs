using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        
       public string OutputNumber(int yourNumber)
           {
                if (yourNumber % 3 == 0 && !(yourNumber % 5 == 0))
                {
                    return "Fizz";
                }
                if (yourNumber % 5 == 0 && !(yourNumber % 3 == 0))
                {
                    return "Buzz";
                }
                if (yourNumber % 3 == 0 && yourNumber % 5 == 0)
                {
                    return "FizzBuzz";
                }

                return yourNumber.ToString();// zwracanie liczby która nie spełnia warunków
            }
        
    }
}
