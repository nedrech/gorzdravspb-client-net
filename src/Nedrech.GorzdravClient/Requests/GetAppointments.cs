namespace Nedrech.GorzdravClient.Requests;

public class GetAppointments : RequestBase
{
    public GetAppointments(ushort clinicId, string doctorId)
        : base($"schedule/lpu/{clinicId}/doctor/{doctorId}/appointments", HttpMethod.Get)
    {
    }
}