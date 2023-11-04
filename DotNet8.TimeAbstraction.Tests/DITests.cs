using FluentAssertions;
using NSubstitute;
using System;

namespace DotNet8.TimeAbstraction.DITests;

public class DITests
{
    private readonly ITimeProvider _timeProvider = Substitute.For<ITimeProvider>();
    private readonly DIGreeterService _greeter;

    public DITests() {
        _greeter = new DIGreeterService(_timeProvider);
    }

    [Fact]
    public void TestGodEftermiddag()
    {
        // Arrange
        _timeProvider.GetLocalNow().Returns(new DateTimeOffset(2023, 11, 11, 12, 50, 0, TimeSpan.FromHours(1)));

        // Act
        var message = _greeter.Greet();

        // Assert
        message.Should().Contain("eftermiddag");
        message.Should().Contain("12:50");
    }

    [Fact]
    public void TestGodMorgon()
    {
        // Arrange
        _timeProvider.GetLocalNow().Returns(new DateTimeOffset(2023, 11, 11, 9, 50, 0, TimeSpan.FromHours(1)));

        // Act
        var message = _greeter.Greet();

        // Assert
        message.Should().Contain("morgon");
        message.Should().Contain("09:50");
    }
}

//_timeProvider.LocalTimeZone.Returns(TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time"));
  //      _timeProvider.GetUtcNow().Returns(new DateTimeOffset(2023, 11, 11, 11, 50, 0, TimeSpan.Zero));
