using DotNetHW2;

namespace Service;

public interface IItemService
{
    public void AddItem(User user, Item item, int quantity);
    public void BuyItem(User user);
}