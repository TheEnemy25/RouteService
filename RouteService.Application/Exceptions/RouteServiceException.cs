namespace RouteService.Application.Exceptions
{
    public class RouteServiceException : Exception
    {
        public int StatusCode { get; set; }

        public RouteServiceException(string message, int code)
          : base(message)
        {
            StatusCode = code;
        }

        public RouteServiceException(string message, Exception innerException, int code)
            : base(message, innerException)
        {
            StatusCode = code;
        }

        public RouteServiceException(RouteServiceException ex)
        {

        }

    }
}
