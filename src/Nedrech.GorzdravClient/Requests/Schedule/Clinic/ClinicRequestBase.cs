namespace Nedrech.GorzdravClient.Requests.Schedule.Clinic;

public class ClinicRequestBase : ScheduleRequestBase
{
    protected ClinicRequestBase(string methodName, HttpMethod method)
        : base("lpu/" + methodName, method)
    {
    }
}