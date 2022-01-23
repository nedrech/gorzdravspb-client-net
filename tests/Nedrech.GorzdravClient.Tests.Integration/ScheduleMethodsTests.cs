using System.Diagnostics;
using System.Threading.Tasks;
using Nedrech.GorzdravClient.Exceptions;
using NUnit.Framework;

namespace Nedrech.GorzdravClient.Tests.Integration;

public class ScheduleMethodsTests
{
    private GorzdravClient ApiClient { get; set; } = null!;

    [SetUp]
    public void SetUp()
    {
        ApiClient = new GorzdravClient();
    }

    [Test]
    public void Should_Throws_On_Wrong_Specialty_Id()
    {
        var ex = Assert.ThrowsAsync<ApiRequestException>(async () =>
            await ApiClient.GetSpecialtiesAsync("77777"));

        Debug.Assert(ex != null);

        Assert.That(ex.ErrorCode, Is.EqualTo(610));
    }

    [Test]
    public async Task It_Should_Give_Out_Specialties()
    {
        var specialties = await ApiClient.GetSpecialtiesAsync("259");

        foreach (var specialty in specialties)
        {
            Assert.NotNull(specialty.Id);
            Assert.NotNull(specialty.Name);
        }
    }
}