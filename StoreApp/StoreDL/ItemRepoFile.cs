using System.Collections.Generic;
using StoreModels;
using System.IO;
using System.Text.Json;
using System;
namespace StoreDL
{
    public class ItemRepoFile : IItemRepository
    {
        private string jsonString;
        private string filePath = "../StoreDL/ItemFiles.json";
        public Item AddItem(Item newItem)
        {
            List<Item> itemsFromFile = GetItems();
            itemsFromFile.Add(newItem);
            jsonString = JsonSerializer.Serialize(itemsFromFile);
            File.WriteAllText(filePath, jsonString);
            return newItem;
        }

        public List<Item> GetItems()
        {
            try
            {
                jsonString = File.ReadAllText(filePath);
            }
            catch (Exception)
            {
                return new List<Item>();
            }
            return JsonSerializer.Deserialize<List<Item>>(jsonString);
        }
    }
}