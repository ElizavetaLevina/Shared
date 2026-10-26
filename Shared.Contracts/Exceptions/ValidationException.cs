using System.Net;

namespace Shared.Contracts.Exceptions
{
    public class ValidationException : BaseException
    {
        public Dictionary<string, string[]>? Errors { get; }

        public ValidationException(string message) : base(message, HttpStatusCode.BadRequest) {}

        public ValidationException(Dictionary<string, string[]> errors) : base("Ошибка валидации данных", HttpStatusCode.BadRequest)
        {
            Errors = errors;
        }
    }
}
