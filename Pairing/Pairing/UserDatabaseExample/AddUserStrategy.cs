namespace Pairing;

public class AddUserStrategy
{
    public void Execute(User newUser)
    {
        var database = new UserDatabaseAdapter();
        var existingUser = database.Get(newUser);
        if (existingUser != null)
        {
            return;
        }

        database.Add(newUser);
    }
}
