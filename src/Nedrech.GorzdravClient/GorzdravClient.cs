namespace Nedrech.GorzdravClient;

/// <summary>
///     Клиент для обращение к Gorzdrav API.
/// </summary>
public class GorzdravClient
{
    private const string BaseGorzdravURL = "https://gorzdrav.spb.ru";
    private const string BaseGorzdravApiURN = "/_api/api/v2/";
        
    private readonly HttpClient _httpClient;
    private readonly Uri _baseUri;

    /// <summary>
    ///     Время ожидания ответа для запроса.
    /// </summary>
    public TimeSpan Timeout
    {
        get => _httpClient.Timeout;
        set => _httpClient.Timeout = value;
    }

    /// <summary>
    ///     Создает новый инстанс <see cref="GorzdravClient"/>.
    /// </summary>
    /// <param name="httpClient">
    ///     Кастомный <see cref="HttpClient"/>.
    /// </param>
    public GorzdravClient(HttpClient? httpClient = null)
    {
        
        
        _httpClient = httpClient ?? new HttpClient();
    }
    
}