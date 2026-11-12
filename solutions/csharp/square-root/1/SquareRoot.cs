public static class SquareRoot
{
    public static int Root(int number)
    {
        int currentNum = 1;
        while (true)
        {
            if (currentNum * currentNum == number)
            {
                return currentNum;
            }
            currentNum += 1;
        }
    }
}
