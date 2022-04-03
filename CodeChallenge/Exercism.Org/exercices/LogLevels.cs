using System;

namespace Exercism.Org.exercices
{
    static class LogLine
    {
        public static string Message(string logLine)
            => logLine[(logLine.IndexOf(':') + 1)..].Trim();

        public static string LogLevel(string logLine)
            => logLine[1..logLine.IndexOf(']')].ToLower();
        public static string Reformat(string logLine)
            => $"{Message(logLine)} ({LogLevel(logLine)})";
    }
    /*
    Assert.Equal("Stack overflow", LogLine.Message("[ERROR]: Stack overflow"));
    Assert.Equal("Disk almost full", LogLine.Message("[WARNING]: Disk almost full"));
    Assert.Equal("File moved", LogLine.Message("[INFO]: File moved"));
    Assert.Equal("Timezone not set", LogLine.Message("[WARNING]:   \tTimezone not set  \r\n"));
    */
}