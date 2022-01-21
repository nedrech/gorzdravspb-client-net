namespace Nedrech.GorzdravClient.Requests.Shared;

public class GetClinics : SharedRequestBase
{
    public GetClinics()
        : base("lpus", HttpMethod.Get)
    {
    }
}