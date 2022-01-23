namespace Nedrech.GorzdravClient.Requests;

public class GetClinics : RequestBase
{
    public GetClinics()
        : base("shared/lpus", HttpMethod.Get)
    {
    }
}