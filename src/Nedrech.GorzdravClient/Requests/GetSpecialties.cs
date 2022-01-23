namespace Nedrech.GorzdravClient.Requests;

public class GetSpecialties : RequestBase
{
    public GetSpecialties(string clinicId)
        : base($"schedule/{clinicId}/specialties", HttpMethod.Get)
    {
    }
}