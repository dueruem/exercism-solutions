public static class LineUp
{
    public static string Format(string name, int number)
    {
        string WrittenNumber;
        if (number % 10 == 1 && number % 100 != 11)
        {
            WrittenNumber = $"{number}st";
        }
        else if(number % 10 == 2 && number % 100 != 12)
        {
            WrittenNumber = $"{number}nd";
        }
        else if(number % 10 == 3 && number % 100 != 13)
        {
            WrittenNumber = $"{number}rd";
        }
        else
        {
            WrittenNumber = $"{number}th";
        }

        return $"{name}, you are the {WrittenNumber} customer we serve today. Thank you!";
    }
}
