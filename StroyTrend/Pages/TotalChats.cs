public class TotalChats
{
    public string name { get; set; } = String.Empty;
    public Request request { get; set; }

    public int total;
    public Dictionary<string, TotalChatsRecord> records { get; set; }
    public class TotalChatsRecord
    {
        public int total { get; set; }
    }
}