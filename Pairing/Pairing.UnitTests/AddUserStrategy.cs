using Xunit;

namespace Pairing.UnitTests;

public class AddUserStrategyShould
{
    [Fact]
    public void AddUserToDatabase_GivenUserDoesNotExist()
    {
        // Arrange
        var strategy = new AddUserStrategy();
        var user = new User { Name = "James" };

        // Act
        strategy.Execute(user);

        // Assert
    }
}
