namespace Forum.Api
{
    public class ApiResponse
    {
        public string Message {  get; set; }
        public bool IsSucess { get; set; }
        public object Result { get; set; }
        public int StatusCode { get; set; }
    }
}
