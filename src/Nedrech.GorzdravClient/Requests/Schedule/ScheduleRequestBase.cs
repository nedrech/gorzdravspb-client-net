namespace Nedrech.GorzdravClient.Requests.Schedule;

public class ScheduleRequestBase : RequestBase
{
    protected ScheduleRequestBase(string methodName) : this(methodName, HttpMethod.Get)
    {
    }

    protected ScheduleRequestBase(string methodName, HttpMethod method)
        : base("schedule/" + methodName, method)
    {
    }
}