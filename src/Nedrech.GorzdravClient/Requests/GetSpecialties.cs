namespace Nedrech.GorzdravClient.Requests;

public class GetSpecialties : RequestBase
{
    public GetSpecialties(int clinicId)
        : base($"schedule/lpu/{clinicId}/specialties", HttpMethod.Get)
    {
    }
}