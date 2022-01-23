using System.Text.Json.Serialization;
using Nedrech.GorzdravClient.Entities.Enums;

namespace Nedrech.GorzdravClient.Entities;

/// <summary>
///     Информация о районе.
/// </summary>
public class District
{
    /// <summary>
    ///     Имя района.
    /// </summary>
    [JsonPropertyName("name")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DistrictName Name { get; set; }

    /// <summary>
    ///     5 цифр ОКАТО.
    /// </summary>
    [JsonPropertyName("okato")]
    public ushort Okato { get; set; }
}