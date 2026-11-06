using Xunit.Sdk;

public class Player
{
    Random rnd = new();
    public int RollDie()
    {
        return rnd.Next(1,19);
    }

    public double GenerateSpellStrength()
    {
        return rnd.NextDouble() + rnd.Next(0, 100);
    }
}
