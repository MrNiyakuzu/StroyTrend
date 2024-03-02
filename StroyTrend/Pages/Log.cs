public class Log
{
    public string name { get; set; } = String.Empty;
    public Request request { get; set; }
    public int total;
    public Dictionary<string, Record> records { get; set; }
    public class Record
    {
    }
}