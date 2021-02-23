using StoreModels;
using System.Collections.Generic;
namespace StoreBL
{
    public interface IItemBL
    {
        List<Item> GetItems();
        void AddItem(Item newItem);
    }
}