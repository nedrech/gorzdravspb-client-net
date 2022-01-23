using System.Text.Json.Serialization;

namespace Nedrech.GorzdravClient.Models;

/// <summary>
///     Информация о враче.
/// </summary>
public class Doctor
{
    /// <summary>
    ///     Идентификатор врача.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    /// <summary>
    ///     Имя врача.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    ///     Количество свободных номерков.
    /// </summary>
    [JsonPropertyName("freeTicketCount")]
    public ushort FreeTicketCount { get; set; }

    /// <summary>
    ///     Номер участков.
    /// </summary>
    [JsonPropertyName("ariaNumber")]
    public string? AriaNumber { get; set; }

    /// <summary>
    ///     Дата и время самого позднего номерка из доступных.
    /// </summary>
    [JsonPropertyName("lastDate")]
    public DateTimeOffset? LastDate { get; set; }

    /// <summary>
    ///     Дата и время ближайшего номерка.
    /// </summary>
    [JsonPropertyName("nearestDate")]
    public DateTimeOffset? NearestDate { get; set; }
}