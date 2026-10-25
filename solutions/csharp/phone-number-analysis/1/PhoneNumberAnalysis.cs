public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool IsNewYork;
        if (phoneNumber.Split("-")[0] == "212")
        {
            IsNewYork = true;
        }
        else
        {
            IsNewYork = false;
        }

        bool IsFake;
        if (phoneNumber.Split("-")[1] == "555")
        {
            IsFake = true;
        }
        else
        {
            IsFake = false;
        }

        string LocalNumber = phoneNumber.Split("-")[2];

        return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
