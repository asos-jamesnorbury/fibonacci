namespace Pairing;

public interface IUserDatabaseAdapter
{
    void Add(User user);
    User Get(User user);
}