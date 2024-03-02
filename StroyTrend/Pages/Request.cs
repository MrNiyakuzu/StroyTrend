public class Request
{
    public string distribution { get; set; } = String.Empty;
    public Filter filters { get; set; }
    public class Filter
    {
        public string from { get; set; } = String.Empty;
        public string to { get; set; } = String.Empty;
        public Group groups { get; set; }
        public class Group
        {
            public List<int> values { get; set; }
        }
    }
}