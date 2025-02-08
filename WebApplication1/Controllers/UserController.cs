using DotNetHW2;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace WebApplication1.Controllers;

public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private User _user;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public IActionResult Register(string username, string password)
    {
        try
        {
            _user = _userService.RegisterUser(username, password);
            Database.getDatabase().UserList.Add(_user);
            ItemController.init(_user);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("login")]
    public IActionResult Login(string username, string password)
    {
        try
        {
            _user = _userService.GetUser(username, password);
            if (_user == null)
                return Unauthorized("Invalid username or password");
            ItemController.init(_user);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("change-username")]
    public IActionResult ChangeUsername(string username, string password, string newUsername)
    {
        try
        {
            _user = _userService.GetUser(username, password);
            if (_user == null)
                return Unauthorized("Invalid username or password");

            _userService.ChangeUsername(_user, newUsername, username);
            return Ok("Username changed successfully.");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("change-password")]
    public IActionResult ChangePassword(string username, string password, string newPassword)
    {
        try
        {
            _user = _userService.GetUser(username, password);
            if (_user == null)
            {
                return Unauthorized("Invalid username or password");
            }

            _userService.ChangePassword(_user, newPassword, username);
            return Ok("Password changed successfully.");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut("increase-credits")]
    public IActionResult IncreaseCredits(int credits)
    {
        if (_user == null)
            return Unauthorized();
        {
        }
        try
        {
            _userService.IncreaseCredentials(_user, credits);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}