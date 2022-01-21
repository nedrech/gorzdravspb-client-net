using Nedrech.GorzdravClient.Models;

namespace Nedrech.GorzdravClient.Requests.Shared;

public class GetDistricts : SharedRequestBase<IEnumerable<District>>
{
    protected GetDistricts()
        : base("districts", HttpMethod.Get)
    {
    }
}