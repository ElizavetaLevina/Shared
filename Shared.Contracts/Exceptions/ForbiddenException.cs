using System.Net;

namespace Shared.Contracts.Exceptions
{
    public class ForbiddenException(string message) : BaseException(message, HttpStatusCode.Forbidden) { }
}
