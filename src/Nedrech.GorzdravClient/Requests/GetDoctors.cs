namespace Nedrech.GorzdravClient.Requests;

public class GetDoctors : RequestBase
{
    public GetDoctors(ushort clinicId, int specialityId)
        : base($"schedule/lpu/{clinicId}/speciality/{specialityId}/doctors", HttpMethod.Get)
    {
    }
}