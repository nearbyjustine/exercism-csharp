static class LogLine
{
  public static string Message(string logLine)
  {
    var indexOfColon = logLine.IndexOf(':') + 1;
    var message = logLine[indexOfColon..logLine.Length];
    return message.Trim();
  }

  public static string LogLevel(string logLine)
  {
    int indexOfLastBracket = logLine.IndexOf(']');
    int indexOfFirstBracket = 1;
    var logLevel = logLine[indexOfFirstBracket..indexOfLastBracket];
    return logLevel.ToLower();
  }

  public static string Reformat(string logLine)
  {
    var message = LogLine.Message(logLine);
    var logLevel = LogLine.LogLevel(logLine);
    return $"{message} ({logLevel})";
  }
}
