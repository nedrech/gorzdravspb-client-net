using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nedrech.GorzdravClient.Requests.Abstractions;

namespace Nedrech.GorzdravClient.Requests;

/// <summary>
///     Описывает запрос к Api сервиса.
/// </summary>
public class RequestBase : IRequest
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

    /// <inheritdoc />
    [JsonPropertyName("method")]
    public string MethodName { get; }

    /// <inheritdoc />
    [JsonIgnore]
    public HttpMethod Method { get; }

    /// <inheritdoc />
    public HttpContent ToHttpContent()
    {
        var payload = JsonSerializer.Serialize(this);
        return new StringContent(payload, Encoding.UTF8, "application/json");
    }
}