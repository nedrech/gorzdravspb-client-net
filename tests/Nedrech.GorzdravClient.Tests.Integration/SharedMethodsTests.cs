using System.Threading.Tasks;
using NUnit.Framework;

namespace Nedrech.GorzdravClient.Tests.Integration;

public class SharedMethodsTests
{
    private GorzdravClient ApiClient { get; set; } = null!;

    [SetUp]
    public void SetUp()
    {
        ApiClient = new GorzdravClient();
    }

    [Test]
    public async Task It_Should_Give_Out_Districts()
    {
        var districts = await ApiClient.GetDistrictsAsync();

        Assert.NotNull(districts);
        Assert.IsNotEmpty(districts);

        foreach (var district in districts)
        {
            Assert.False(district.Okato == default);
            Assert.False(district.Name == default);
        }
    }

    [Test]
    public async Task It_Should_Give_Out_Clinics()
    {
        var clinics = await ApiClient.GetClinicsAsync();

        Assert.NotNull(clinics);
        Assert.IsNotEmpty(clinics);

        foreach (var clinic in clinics)
        {
            Assert.False(clinic.Id == default);
            Assert.False(clinic.DistrictName == default);
            Assert.False(string.IsNullOrEmpty(clinic.FullName));
            Assert.False(string.IsNullOrEmpty(clinic.ShortName));
            Assert.False(string.IsNullOrEmpty(clinic.Phone));
        }
    }
}