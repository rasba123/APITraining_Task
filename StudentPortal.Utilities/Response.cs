namespace StudentPortal
{
    public class Response
    {
        public int StatusCode { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public object Id { get; set; }
        public object Data { get; set; }
        public int Count { get; set; }
    }
}
