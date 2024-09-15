using DotNetHW2;

namespace Service;

public class UserService : IUserService
{
    public User RegisterUser(string username, string password)
    {
        return new User(username, password);
    }

    public void ChangePassword(User user, string oldPassword, string newPassword)
    {
        user.password = newPassword;
    }

    public void ChangeUsername(User user, string newUsername, string oldUsername)
    {
        user.username = newUsername;
    }

    public void IncreaseCredentials(User user, double newCredentials)
    {
        user.credit += newCredentials;
    }
}