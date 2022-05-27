using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryManager
{
    internal class InventoryManagement
    {
        List<InventoryItems> inventoryItems = new List<InventoryItems>();
        InventoryItems inventoryItem = new InventoryItems();

        public void ConvertJson(string jsonFilePath)
        {
            StreamReader reader = new StreamReader(jsonFilePath);
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<InventoryItems>>(json);
                Console.WriteLine("   Grain       Price      Weight     TotalValue");
                Console.WriteLine("-----------------------------------------------");
                foreach (var item in items)
                {
                    double value = item.price * item.weight;
                    Console.WriteLine("   "+item.Name+"    Rs."+item.price+"    "+item.weight+"kg    Rs."+value);
                }
            }
        }
    }
}
