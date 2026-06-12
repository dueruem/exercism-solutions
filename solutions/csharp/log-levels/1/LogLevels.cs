static class LogLine
{
    public static string Message(string logLine)
    {
        string[] logSplit = logLine.Split("]: ");
        string logMessage = logSplit[1];
        return logMessage.Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] logSplit = logLine.Split("[");
        string[] logSplit2 = logSplit[1].Split("]");
        return logSplit2[0].ToLower();
    }

    public static string Reformat(string logLine)
    {
        string logLevel = LogLine.LogLevel(logLine);
        string logMessage = LogLine.Message(logLine);
        return $"{logMessage} ({logLevel})";
    }
}
