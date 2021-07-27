namespace DatingApp.Errors
{
    public class ApiException
    {
        public ApiException(int statusCode, string message = null, string details=null)
        {
            StatusCode = statusCode;
            Message = message;
            Detaild = details;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Detaild { get; set; }
    }
}