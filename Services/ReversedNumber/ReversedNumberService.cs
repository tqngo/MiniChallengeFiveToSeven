namespace MiniChallengeFiveToSeven.Services.ReversedNumber;

public class ReversedNumberService : IReversedNumberService
{
    public string Reversal(string numbahs)
    {
        string word = "";

        bool valid = Int32.TryParse(numbahs, out int numbers);

        if (valid)
        {
            for (int i = numbahs.Length - 1; i >= 0; i--)
            {
                word += numbahs[i];

            }
            return $"You entered {numbahs}, reversed is {word}";
        }
        else
        {
            return "Invalid entry. Please input a number.";
        }
    }
}
