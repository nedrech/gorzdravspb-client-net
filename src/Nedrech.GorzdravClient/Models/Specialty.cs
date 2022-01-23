using System.Text.Json.Serialization;

namespace Nedrech.GorzdravClient.Models;

public class Specialty
{
    /// <summary>
    ///     Идентификатор специальности.
    /// </summary>
    [JsonPropertyName("id")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public int Id { get; set; }

    /// <summary>
    ///     Название специальности.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    ///     Количество свободных номерков.
    /// </summary>
    /// <remarks>
    ///     Используется вместо countFreeTicket из Api, т.к. имеет более реальный показатель.
    /// </remarks>
    [JsonPropertyName("countFreeParticipant")]
    public ushort FreeTicketsCount { get; set; }

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