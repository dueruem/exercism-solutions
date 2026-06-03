class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int OvenTime)
    {
        return ExpectedMinutesInOven() - OvenTime;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method

    public int PreperationTimeInMinutes(int Layers)
    {
        return Layers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ElapsedTimeInMinutes(int Layers, int OvenTime)
    {
        return Layers * 2 + OvenTime;
    }
}
