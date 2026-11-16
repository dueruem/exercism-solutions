public static class Darts
{
    public static int Score(double x, double y)
    {
        double centerDistance = Math.Sqrt(x*x+y*y);
        
        if (centerDistance >= 10)
        {
            return 0;
        }

        if (centerDistance >= 5)
        {
            return 1;
        }

        if (centerDistance >= 1)
        {
            return 5;
        }

        return 10;
    }
}
