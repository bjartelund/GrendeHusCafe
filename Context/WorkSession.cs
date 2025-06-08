namespace Context;


    public class WorkSession
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }