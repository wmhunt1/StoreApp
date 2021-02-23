using StoreModels;
using System.Collections.Generic;
namespace StoreDL
{
    public class ItemRepoSC : IItemRepository
    {
        public List<Item> GetItems()
        {
            return Storage.AllItems;
        }
        public Item AddItem(Item newItem)
        {
            Storage.AllItems.Add(newItem);
            return newItem;
        }
    }
}