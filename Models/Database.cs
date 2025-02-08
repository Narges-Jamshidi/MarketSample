namespace DotNetHW2;

public class Database
{
    public List<User> UserList { get; set; }

    private Database()
    {
        UserList = new List<User>();
    }

    private static Database DatabaseInstance;

    public static Database getDatabase()
    {
        if (DatabaseInstance == null)
        {
            DatabaseInstance = new Database();
        }

        return DatabaseInstance;
    }
}