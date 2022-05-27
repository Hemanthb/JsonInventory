// See https://aka.ms/new-console-template for more information
check:
Console.WriteLine("Enter 1 -> grains Inventory 2 -> Stock Inventory");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        InventoryManager.InventoryManagement inventory = new InventoryManager.InventoryManagement();
        inventory.ConvertJson(@"D:\blabz_fellowship\JsonInventory\InventoryManager\InventoryManager\GrainsInventory.json");
        break;
    case 2:
        InventoryManager.StockPortfolio stocks = new InventoryManager.StockPortfolio();
        stocks.convertFromJson(@"D:\blabz_fellowship\JsonInventory\InventoryManager\InventoryManager\jsStockPortfolio.json");
        break;
    default:
        Console.WriteLine("Invalid choice: enter 1 or 2");
        goto check;
        
}
