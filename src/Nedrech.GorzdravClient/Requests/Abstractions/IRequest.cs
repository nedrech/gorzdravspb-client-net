namespace Nedrech.GorzdravClient.Requests.Abstractions;

/// <summary>
///     Описывает запрос к API сервиса.
/// </summary>
public interface IRequest
{
    /// <summary>
    ///     Имя метода API.
    /// </summary>
    string MethodName { get; }

    /// <summary>
    ///     HTTP метод запроса.
    /// </summary>
    HttpMethod Method { get; }

    /// <summary>
    ///     Генерирует <see cref="HttpContent" /> запроса.
    /// </summary>
    /// <returns><see cref="HttpContent" /> запроса.</returns>
    HttpContent ToHttpContent();
}