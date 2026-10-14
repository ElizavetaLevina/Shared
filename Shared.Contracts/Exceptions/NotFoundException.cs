using System.Net;

namespace Shared.Contracts.Exceptions
{
    public class NotFoundException(string message) : BaseException(message, HttpStatusCode.NotFound) { }
}
