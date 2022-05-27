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
       
        InventoryFactory inventoryFactory = new InventoryFactory();
        List<InventoryItems> riceVarieties = new List<InventoryItems>();
        List<InventoryItems> wheatVarieties = new List<InventoryItems>();
        List<InventoryItems> pulseVarieties= new List<InventoryItems>();
        public void ConvertJson(string jsonFilePath)
        {
            StreamReader reader = new StreamReader(jsonFilePath);
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<InventoryFactory>(json);
                riceVarieties = items.rice;
                wheatVarieties = items.wheat;
                pulseVarieties = items.pulses;
                Console.WriteLine("Enter your choice to print details of grains\n" +
                    "1 -> Rice\n2 -> Wheat\n3 -> Pulses");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("   Grain       Price      Weight     TotalPrice");
                Console.WriteLine("-----------------------------------------------");
                switch (choice)
                {
                    case 1:
                        foreach (var rice in riceVarieties)
                        {
                            double value = rice.price * rice.weight;
                            Console.WriteLine("   " + rice.Name + "    Rs." + rice.price + "    " + rice.weight + "kg    Rs." + value);
                        }
                        break;
                    case 2:
                        foreach (var wheat in wheatVarieties)
                        {
                            double value = wheat.price * wheat.weight;
                            Console.WriteLine("   " + wheat.Name + "    Rs." + wheat.price + "    " + wheat.weight + "kg    Rs." + value);
                        }
                        break;
                    case 3:
                        foreach (var pulses in pulseVarieties)
                        {
                            double value = pulses.price * pulses.weight;
                            Console.WriteLine("   " + pulses.Name + "    Rs." + pulses.price + "    " + pulses.weight + "kg    Rs." + value);
                        }
                        break;
                    default:
                        Console.WriteLine("Enter a valid input from 1-3");
                        break;
                }
                
            }
        }
    }
}
