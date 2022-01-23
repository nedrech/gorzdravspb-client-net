using System;
using System.Collections.Generic;
using System.Diagnostics;
using Nedrech.GorzdravClient.Exceptions;
using Nedrech.GorzdravClient.Models;
using Nedrech.GorzdravClient.Requests.Shared;
using NUnit.Framework;

namespace Nedrech.GorzdravClient.Tests.Unit;

public class HttpClientTests
{
    private GorzdravClient ApiClient { get; set; } = null!;

    [SetUp]
    public void SetUp()
    {
        ApiClient = new GorzdravClient();
    }

    [Test]
    public void Should_Throw_Timeout()
    {
        ApiClient.Timeout = TimeSpan.FromMilliseconds(1);

        var ex = Assert.ThrowsAsync<ApiRequestException>(async () =>
            await ApiClient.MakeRequestAsync<ICollection<District>>(new GetDistricts()));

        Debug.Assert(ex != null);

        Assert.That(ex.Message, Is.EqualTo("Request timed out."));
    }
}