using System.Text.Json.Serialization;

namespace Nedrech.GorzdravClient.Entities;

/// <summary>
///     Ответ от API сервиса.
/// </summary>
/// <typeparam name="TResult">Обобщение получаемого типа.</typeparam>
public class ApiResponse<TResult>
{
    /// <summary>
    ///     Тело результата запроса.
    /// </summary>
    [JsonPropertyName("result")]
    public TResult? Result { get; set; }

    /// <summary>
    ///     Определяет, успешно ли выполнен запрос.
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    /// <summary>
    ///     Код ошибки.
    /// </summary>
    [JsonPropertyName("errorCode")]
    public ushort ErrorCode { get; set; }

    /// <summary>
    ///     Сообщение об ошибке.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}