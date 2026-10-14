using System.Net;

namespace Shared.Contracts.Exceptions
{
    public class BaseException(string message, HttpStatusCode statusCode = HttpStatusCode.InternalServerError) : Exception(message)
    {
        public HttpStatusCode StatusCode { get; } = statusCode;
    }
}
