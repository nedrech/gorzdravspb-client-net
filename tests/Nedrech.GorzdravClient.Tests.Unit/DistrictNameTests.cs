using System;
using Nedrech.GorzdravClient.Models.Enums;
using NUnit.Framework;

namespace Nedrech.GorzdravClient.Tests.Unit;

public class DistrictNameTests
{
    [Test]
    public void Enumeration_Must_Start_With_One()
    {
        byte digit = 1;
        foreach (var districtNumber in (byte[]) Enum.GetValues(typeof(DistrictName)))
        {
            Assert.AreEqual(digit, districtNumber);
            digit++;
        }
    }
}