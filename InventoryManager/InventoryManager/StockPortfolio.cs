using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryManager
{
    internal class StockPortfolio
    {
        Stock stock = new Stock();
        List<Stock> stocks = new List<Stock>();
        public void convertFromJson(string jFilePath)
        {
            using (StreamReader reader = new StreamReader(jFilePath))
            {
                var read = reader.ReadToEnd();
                var share = JsonConvert.DeserializeObject<List<Stock>>(read);
                Console.WriteLine("Company       Stock No's       Share Price       Total Value");
                double totalValue = 0;
                foreach (var objects in share)
                {
                    double value = objects.noOfShares * objects.sharePrice;
                    totalValue += value;
                    Console.WriteLine(objects.shareName + "   " + objects.noOfShares + "   " + objects.sharePrice + "   " + value);

                }
                Console.WriteLine("\nTotal Value of all Stocks is Rs.: " + totalValue);
            }
        }
    }
}
