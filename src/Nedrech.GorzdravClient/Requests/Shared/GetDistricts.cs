namespace Nedrech.GorzdravClient.Requests.Shared;

public class GetDistricts : SharedRequestBase
{
    public GetDistricts()
        : base("districts", HttpMethod.Get)
    {
    }
}