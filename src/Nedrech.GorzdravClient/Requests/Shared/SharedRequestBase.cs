namespace Nedrech.GorzdravClient.Requests.Shared;

public class SharedRequestBase : RequestBase
{
    protected SharedRequestBase(string methodName, HttpMethod method)
        : base("shared/" + methodName, method)
    {
    }
}