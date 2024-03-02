public class Duration : Log
{
    new public Dictionary<string, Record> records { get; set; }
    new public class Record
    {
        public int agents_chatting_duration { get; set; }
        public int count { get; set; }
        public int duration { get; set; }
    }
}