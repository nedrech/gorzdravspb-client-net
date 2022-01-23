using System.Diagnostics;
using System.Threading.Tasks;
using Nedrech.GorzdravClient.Exceptions;
using NUnit.Framework;

namespace Nedrech.GorzdravClient.Tests.Integration;

public class ApiMethodsTests
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
            await ApiClient.GetSpecialtiesAsync(77777));

        Debug.Assert(ex != null);

        Assert.That(ex.ErrorCode, Is.EqualTo(610));
    }

    [Test]
    public async Task Should_Give_Out_Specialties()
    {
        var specialties = await ApiClient.GetSpecialtiesAsync(1);

        Assert.IsNotEmpty(specialties);

        foreach (var specialty in specialties)
        {
            Assert.NotNull(specialty.Id);
            Assert.NotNull(specialty.Name);
        }
    }

    [Test]
    public async Task Should_Give_Out_Districts()
    {
        var districts = await ApiClient.GetDistrictsAsync();

        Assert.IsNotEmpty(districts);

        foreach (var district in districts)
        {
            Assert.False(district.Okato == default);
            Assert.False(district.Name == default);
        }
    }

    [Test]
    public async Task Should_Give_Out_Clinics()
    {
        var clinics = await ApiClient.GetClinicsAsync();

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

    [Test]
    public async Task Should_Give_Out_Doctors()
    {
        var doctors = await ApiClient.GetDoctorsAsync(1, 92137086);

        Assert.IsNotEmpty(doctors);

        foreach (var doctor in doctors)
        {
            Assert.NotNull(doctor.Id);
            Assert.NotNull(doctor.Name);
        }
    }
}