namespace DotNetHW2;

public class User
{
    public string username { get; set; }
    public string password { get; set; }
    public double credit {get;set;}
    private List<Item> items = new List<Item>();

    public User(string username, string password)
    {
        this.username = username;
        this.password = password;
        this.credit = 50;
    }

    public void SetItemToList(Item item)
    {
        items.Add(item);
    }

    public List<Item> GetItems()
    {
        return items;
    }

}