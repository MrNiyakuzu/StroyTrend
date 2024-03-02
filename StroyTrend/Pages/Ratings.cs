public class Ratings : Log
{
    new public Dictionary<string, Record> records { get; set; }
    new public class Record
    {
        public int bad { get; set; }
        public int chats { get; set; }
        public int good { get; set; }
    }
}