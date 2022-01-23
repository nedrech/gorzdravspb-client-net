using System.Text.Json.Serialization;
using Nedrech.GorzdravClient.Entities.Enums;

namespace Nedrech.GorzdravClient.Entities;

/// <summary>
///     Описание ЛПУ.
/// </summary>
/// <remarks>
///     Содержит не все свойства, возвращаемые из Api.
/// </remarks>
public class Clinic
{
    /// <summary>
    ///     Идентификатор ЛПУ.
    /// </summary>
    [JsonPropertyName("id")]
    public ushort Id { get; set; }

    /// <summary>
    ///     Имя и идентификатор района.
    /// </summary>
    [JsonPropertyName("districtName")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DistrictName DistrictName { get; set; }

    /// <summary>
    ///     Описывает, работает ли ЛПУ в текущий момент.
    /// </summary>
    [JsonPropertyName("isActive")]
    public bool IsActive { get; set; }

    /// <summary>
    ///     Полное название ЛПУ.
    /// </summary>
    [JsonPropertyName("lpuFullName")]
    public string FullName { get; set; } = null!;

    /// <summary>
    ///     Укороченное название ЛПУ.
    /// </summary>
    [JsonPropertyName("lpuShortName")]
    public string ShortName { get; set; } = null!;

    /// <summary>
    ///     Адрес ЛПУ.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    ///     Городской номер телефона ЛПУ.
    /// </summary>
    [JsonPropertyName("phone")]
    public string Phone { get; set; } = null!;

    /// <summary>
    ///     Электронная почта ЛПУ.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    ///     Производит ли ЛПУ вакцинацию.
    /// </summary>
    [JsonPropertyName("covidVaccination")]
    public bool CovidVaccination { get; set; }
}