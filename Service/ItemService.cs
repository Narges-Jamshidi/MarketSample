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
        while (user.GetItems().Count>0)
        {
            if (user.credit > user.GetItems()[1].cost)
            {
                user.credit -= user.GetItems()[1].cost;
                user.GetItems().Remove(user.GetItems()[1]);
            }
            else
            {
                throw new RuntimeBinderException();
            }
        }
        
    }
}