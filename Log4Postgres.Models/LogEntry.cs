using System;

namespace Log4Postgres.Models
{
    public class LogEntry
    {
        public long LogEntryId {get; set;}
        public LogLevel Level {get; set;}
        public DateTime EventTime {get; set;}
        public string Message {get; set;}
    }
}