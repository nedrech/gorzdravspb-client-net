namespace Nedrech.GorzdravClient.Requests.Abstractions;

/// <summary>
///     Описывает запрос к Api сервиса.
/// </summary>
/// <typeparam name="TResult">Тип результата, в котором будет возвращен ответ.</typeparam>
public interface IRequest<TResult>
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
    ///     Генерирует <see cref="HttpContent"/> запроса.
    /// </summary>
    /// <returns><see cref="HttpContent"/> запроса.</returns>
    HttpContent ToHttpContent();
}