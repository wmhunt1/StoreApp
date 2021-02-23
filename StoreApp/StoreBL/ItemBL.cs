using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class ItemBL : IItemBL
    {
        private IItemRepository _repo;
        public ItemBL(IItemRepository repo)
        {
            _repo = repo;
        }
        public void AddItem(Item newItem)
        {
            //Todo: Add BL
            _repo.AddItem(newItem);
        }

        public List<Item> GetItems()
        {
            //TODO add BL
            return _repo.GetItems();
        }
    }
}