namespace WebAPI.Common
{
    public class RequestParameter
    {

    }

    public class ResponseParameter
    {
        public bool Success { get; set; }
        public string Code {  get; set; }
        public object Content{ get; set; }

    }
}
