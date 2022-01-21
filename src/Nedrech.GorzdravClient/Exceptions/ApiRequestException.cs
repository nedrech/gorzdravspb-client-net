namespace Nedrech.GorzdravClient.Exceptions;

/// <summary>
///     Исключительная ситуация для ошибок, которые отдаёт Api.
/// </summary>
public class ApiRequestException : Exception
{
    public ApiRequestException(string message)
        : base(message)
    {
    }

    public ApiRequestException(string message, ushort errorCode)
        : base(message)
    {
        ErrorCode = errorCode;
    }

    public ApiRequestException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public ushort ErrorCode { get; }
}