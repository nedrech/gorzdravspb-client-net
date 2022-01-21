namespace Nedrech.GorzdravClient.Requests.Shared;

public class SharedRequestBase<TResult> : RequestBase<TResult>
{
    protected SharedRequestBase(string methodName, HttpMethod method)
        : base(methodName, method)
    {
    }
}