using DotNetHW2;
using Service;

namespace ServiceTest;

using Xunit;

public class UserServiceTest
{
    private UserService userService;
    private User _user;

    public UserServiceTest()
    {
        this.userService = new UserService();
        this._user = new User("username", "password");
    }

    [Fact]
    public void IncreaseCredentialsShouldIncreaseUserCredit()
    {
        userService.IncreaseCredentials(this._user, 100);
        //========================================================
        Assert.Equal(150.0, _user.credit);
    }

    [Fact]
    public void DoesThePasswordChangeFunctionChangeThePassword()
    {
        userService.ChangePassword(_user, "password","newPassword");
        //========================================================
        Assert.Equal("password", _user.password);
    }
    
    [Fact]
    public void DoesTheUsernameChangeFunctionChangeTheUsername()
    {
        userService.ChangeUsername(_user, "username","newUsername");
        //========================================================
        Assert.Equal("newUsername", _user.password);
    }
}