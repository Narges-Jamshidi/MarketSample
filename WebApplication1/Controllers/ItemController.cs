using DotNetHW2;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{
    private readonly IItemService _itemService;
    private static User _user = null;

    public ItemController(IItemService itemService)
    {
        _itemService = itemService;
    }

    public static void init(User user)
    {
        _user = user;
        Console.Write(_user.username);
    }

    [HttpGet("name", Name = "GetItem")]
    public String GetItem()
    {
        return "Hello World";
    }


    [HttpPut("add-item")]
    public IActionResult AddItem([FromBody] Item item, int quantity)
    {
        if (_user == null)
        {
            return Unauthorized();
        }

        try
        {
            _itemService.AddItem(_user, item, quantity);
            return Ok("Item added");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    
}