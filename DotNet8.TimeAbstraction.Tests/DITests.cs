using FluentAssertions;

namespace DotNet8.TimeAbstraction.Tests;

public class DITests
{


    [Fact]
    public void TestGodEftermiddag()
    {
        // Arrange
        var greeter = new QuickAndDirtyGreeterService(new DateTime(2023, 11, 11, 12, 50, 0));

        // Act
        var message = greeter.Greet();

        // Assert
        message.Should().Contain("eftermiddag");
        message.Should().Contain("12:50");
    }

    [Fact]
    public void TestGodMorgon()
    {
        // Arrange
        var greeter = new QuickAndDirtyGreeterService(new DateTime(2023, 11, 11, 9, 50, 0));

        // Act
        var message = greeter.Greet();

        // Assert
        message.Should().Contain("morgon");
        message.Should().Contain("09:50");
    }
}

