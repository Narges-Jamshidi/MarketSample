using DotNetHW2;
using Microsoft.CSharp.RuntimeBinder;

namespace Service;

public class ItemService : IItemService
{
    public void AddItem(User user, Item item, int quantity)
    {
        user.GetItems().Add(item);
    }

    public void BuyItem(User user)
    {
        while (user.GetItems().Count > 0)
        {
            if (user.credit > user.GetItems()[0].cost)
            {
                user.credit -= user.GetItems()[0].cost;
                user.GetItems().Remove(user.GetItems()[0]);
            }
            else
            {
                throw new RuntimeBinderException();
            }
        }
    }

    public void DeleteItem(User user, Item item, int quantity)
    {
        if (user.GetItems().Contains(item) && user.GetItems().Count >= quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                user.GetItems().Remove(item);
            }
        }
        else
        {
            throw new RuntimeBinderException("the item does not exist");
        }
    }
}