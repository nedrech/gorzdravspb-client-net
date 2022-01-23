using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Nedrech.GorzdravClient.Requests;

/// <summary>
///     Описывает запрос к Api сервиса.
/// </summary>
public class RequestBase
{
    /// <summary>
    ///     Создает новый инстанс запроса.
    /// </summary>
    /// <param name="methodName">Имя метода запроса.</param>
    /// <param name="method">HTTP метод запроса.</param>
    protected RequestBase(string methodName, HttpMethod method)
    {
        MethodName = methodName;
        Method = method;
    }

    /// <summary>
    ///     Имя метода API.
    /// </summary>
    [JsonPropertyName("method")]
    public string MethodName { get; }

    /// <summary>
    ///     HTTP метод запроса.
    /// </summary>
    [JsonIgnore]
    public HttpMethod Method { get; }

    /// <summary>
    ///     Генерирует <see cref="HttpContent" /> запроса.
    /// </summary>
    /// <returns><see cref="HttpContent" /> запроса.</returns>
    public HttpContent ToHttpContent()
    {
        var payload = JsonSerializer.Serialize(this);
        return new StringContent(payload, Encoding.UTF8, "application/json");
    }
}