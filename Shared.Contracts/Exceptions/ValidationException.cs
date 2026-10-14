using System.Net;

namespace Shared.Contracts.Exceptions
{
    public class ValidationException(string message) : BaseException(message, HttpStatusCode.BadRequest) { }
}
