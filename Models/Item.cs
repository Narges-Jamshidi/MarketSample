namespace DotNetHW2;

public class Item
{
    private string name { get; }
    private string description { get; }
    public double cost { get; }

    public Item(string name, string description, double cost)
    {
        this.name = name;
        this.description = description;
        this.cost = cost;
    }
}