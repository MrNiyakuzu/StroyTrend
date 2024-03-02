public class ResponseTime : Log
{
    new public Dictionary<string, Record> records { get; set; }
    new public class Record
    {
        public int count { get; set; }
        public double response_time { get; set; }
    }
}