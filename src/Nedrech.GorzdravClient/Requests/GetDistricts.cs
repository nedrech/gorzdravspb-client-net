namespace Nedrech.GorzdravClient.Requests;

public class GetDistricts : RequestBase
{
    public GetDistricts()
        : base("shared/districts", HttpMethod.Get)
    {
    }
}