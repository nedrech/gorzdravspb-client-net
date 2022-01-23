namespace Nedrech.GorzdravClient.Requests.Schedule.Clinic;

public class GetSpecialties : ClinicRequestBase
{
    public GetSpecialties(string clinicId)
        : base($"{clinicId}/specialties", HttpMethod.Get)
    {
    }
}