using Microsoft.VisualBasic;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string text, string delimiter)
    {
        return text.Split(delimiter)[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string text, string delimiter1, string delimiter2)
    {
        return text.Split(delimiter1)[1].Split(delimiter2)[0];
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string text)
    {
        return text.SubstringAfter("]: ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string text)
    {
        return text.SubstringBetween("[", "]");
    }
}