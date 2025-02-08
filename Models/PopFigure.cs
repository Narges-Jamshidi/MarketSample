namespace DotNetHW2;

public class PopFigure : Item
{
    public PopFigure(string name, string description, double cost) : base(name, description, cost)
    {
    }

    public PopFigure() : base("Pop figure", "this is pop figure", 1.0)
    {
    }
}