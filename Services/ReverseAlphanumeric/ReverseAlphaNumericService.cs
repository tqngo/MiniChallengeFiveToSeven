using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeFiveToSeven.Services.ReverseAlphanumeric;

public class ReverseAlphaNumericService : IReverseAlphanumericService
{
    public string ReversedWord(string backwards)
    {
        string word = "";

        for (int i = backwards.Length - 1; i >= 0; i--)
        {
            word += backwards[i];

        }
        return word;
    }
}
