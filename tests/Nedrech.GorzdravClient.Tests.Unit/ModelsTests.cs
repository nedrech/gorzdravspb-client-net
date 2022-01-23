using System;
using Nedrech.GorzdravClient.Entities.Enums;
using NUnit.Framework;

namespace Nedrech.GorzdravClient.Tests.Unit;

public class ModelsTests
{
    [Test]
    public void Id_Must_Start_With_One()
    {
        byte digitId = 1;
        foreach (var districtId in (byte[]) Enum.GetValues(typeof(DistrictName)))
        {
            Assert.AreEqual(digitId, districtId);
            digitId++;
        }
    }
}