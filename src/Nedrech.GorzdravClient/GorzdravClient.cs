using System.Net.Http.Json;
using System.Security.Authentication;
using Nedrech.GorzdravClient.Entities;
using Nedrech.GorzdravClient.Exceptions;
using Nedrech.GorzdravClient.Requests;

namespace Nedrech.GorzdravClient;

/// <summary>
///     Клиент для обращения к Gorzdrav API.
/// </summary>
public class GorzdravClient
{
    private const string BaseGorzdravUrl = "https://gorzdrav.spb.ru";
    private const string BaseGorzdravApiUrn = "_api/api/v2";
    private readonly string _baseUri;

    private readonly HttpClient _httpClient;

    /// <summary>
    ///     Создает новый инстанс <see cref="GorzdravClient" />.
    /// </summary>
    /// <param name="httpClient">
    ///     Кастомный <see cref="HttpClient" />.
    /// </param>
    public GorzdravClient(HttpClient? httpClient = null)
    {
        var handler = new HttpClientHandler
        {
            SslProtocols = SslProtocols.Tls
        };
        _httpClient = httpClient ?? new HttpClient(handler);


        _baseUri = $"{BaseGorzdravUrl}/{BaseGorzdravApiUrn}";
    }

    /// <summary>
    ///     Время ожидания ответа для запроса.
    /// </summary>
    public TimeSpan Timeout
    {
        get => _httpClient.Timeout;
        set => _httpClient.Timeout = value;
    }

    /// <summary>
    ///     Метод для отправки запроса.
    /// </summary>
    /// <param name="request">Запрос <see cref="RequestBase" />.</param>
    /// <param name="cancellationToken">Токен отмены действия <see cref="CancellationToken" />.</param>
    /// <typeparam name="TResult">Результат, в котором ошидает ответ.</typeparam>
    /// <returns>Результат типа <see cref="TResult"/>.</returns>
    /// <exception cref="ApiRequestException"></exception>
    public async Task<TResult> MakeRequestAsync<TResult>(RequestBase request,
        CancellationToken cancellationToken = default)
    {
        var uri = $"{_baseUri}/{request.MethodName}";

        var httpRequest = new HttpRequestMessage(request.Method, uri)
        {
            Content = request.ToHttpContent()
        };

        HttpResponseMessage httpResponse;
        try
        {
            httpResponse = await _httpClient.SendAsync(httpRequest, cancellationToken)
                .ConfigureAwait(false);

            httpResponse.EnsureSuccessStatusCode();
        }
        catch (TaskCanceledException e)
        {
            if (cancellationToken.IsCancellationRequested)
                throw;

            throw new ApiRequestException("Request timed out.", e);
        }
        catch (HttpRequestException e)
        {
            throw new ApiRequestException("HTTP error, see inner.", e);
        }

        var apiResponse =
            await httpResponse.Content.ReadFromJsonAsync<ApiResponse<TResult>>(cancellationToken: cancellationToken)
            ?? throw new ApiRequestException("An empty response was received.");

        if (!apiResponse.Success)
            throw new ApiRequestException(apiResponse.Message!, apiResponse.ErrorCode);

        return apiResponse.Result!;
    }

    /// <summary>
    ///     Метод запроса информации о районах.
    /// </summary>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns><see cref="IEnumerable{T}" /> перечисление с информацией о районах.</returns>
    public Task<ICollection<District>> GetDistrictsAsync(CancellationToken cancellationToken = default)
    {
        return MakeRequestAsync<ICollection<District>>(new GetDistricts(), cancellationToken);
    }

    public Task<ICollection<Clinic>> GetClinicsAsync(CancellationToken cancellationToken = default)
    {
        return MakeRequestAsync<ICollection<Clinic>>(new GetClinics(), cancellationToken);
    }

    public Task<ICollection<Specialty>> GetSpecialtiesAsync(int clinicId,
        CancellationToken cancellationToken = default)
    {
        return MakeRequestAsync<ICollection<Specialty>>(new GetSpecialties(clinicId), cancellationToken);
    }

    public Task<ICollection<Doctor>> GetDoctorsAsync(ushort clinicId, int specialityId,
        CancellationToken cancellationToken = default)
    {
        return MakeRequestAsync<ICollection<Doctor>>(new GetDoctors(clinicId, specialityId), cancellationToken);
    }

    public Task<ICollection<Appointment>> GetAppointmentsAsync(ushort clinicId, string doctorId,
        CancellationToken cancellationToken = default)
    {
        return MakeRequestAsync<ICollection<Appointment>>(new GetAppointments(clinicId, doctorId), cancellationToken);
    }
}