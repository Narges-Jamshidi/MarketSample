namespace DotNetHW2;

public class User
{
    private string username { get; set; }
    private string password { get; set; }
    private int credit {get;set;}
    private List<string> items = new List<string>();

    public User(string username, string password)
    {
        this.username = username;
        this.password = password;
        this.credit = 50;
    }

    public void SetItemToList(string item)
    {
        items.Add(item);
    }

    public List<string> GetItems()
    {
        return items;
    }

}