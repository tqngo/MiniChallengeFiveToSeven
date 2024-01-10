using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeFiveToSeven.Services.OddOrEven;

public class OddOrEvenService : IOddOrEvenService
{
    public string Numerals(string num)
    {


        bool parse = Int32.TryParse(num, out int number);

        if (parse)
        {
            if (number % 2 == 0)
            {
                return $"{number} is an even number";
            }
            else
            {
                return $"{number} is an odd number";
            }
        }
        else
        {
            return "Please enter a valid number.";
        }
    }
}
