using System;

namespace Pairing;

public class UserDatabaseAdapter : IUserDatabaseAdapter
{
    public User Get(User user)
    {
        throw new ArgumentException("Could not connect to the database.");
    }

    public void Add(User user)
    {
        throw new ArgumentException("Could not connect to the database.");
    }
}
