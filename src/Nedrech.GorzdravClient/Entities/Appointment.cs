using System.Text.Json.Serialization;

namespace Nedrech.GorzdravClient.Entities;

/// <summary>
///     Информация о номерке.
/// </summary>
public class Appointment
{
    /// <summary>
    ///     Идентификатор номерка.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    /// <summary>
    ///     Время посещения.
    /// </summary>
    [JsonPropertyName("visitStart")]
    public DateTimeOffset VisitStart { get; set; }

    /// <summary>
    ///     Время окончания посещения.
    /// </summary>
    [JsonPropertyName("visitEnd")]
    public DateTimeOffset VisitEnd { get; set; }

    /// <summary>
    ///     Адрес ЛПУ.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; } = null!;

    /// <summary>
    ///     Номер кабинета.
    /// </summary>
    [JsonPropertyName("room")]
    public string? Room { get; set; }
}