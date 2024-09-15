using DotNetHW2;

namespace Service;

public interface IUserService
{
    public User RegisterUser(string username, string password);
    public void ChangePassword(User user, string oldPassword, string newPassword);
    public void ChangeUsername(User user,  string newPassword, string oldUsername);
    
    public void IncreaseCredentials(User user , double newCredentials);
        
}