using System;

namespace Warehouse
{

    class Program
    {
        
        //Stała
        public const string FILE_NAME = "C:\\Warehousefiles\\ImportFile.xlsx";
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to warehouse app!");
            Console.WriteLine("Please let me know what you want to do:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Check Item");
            Console.WriteLine("Press 1, 2 or 3...");

            string operation = Console.ReadLine();
            
            Console.WriteLine($"You have chosen option number: {operation}");
            
            int chosenOperation = 0;

            Int32.TryParse(operation, out chosenOperation);
            
            Console.WriteLine("Select item category");
            Console.WriteLine("1. Grocery");
            Console.WriteLine("2. Clothing");
            Console.WriteLine("3. Electronics");

            string category = Console.ReadLine();

            helpers.ItemType chosenCategory;
            
            Enum.TryParse(category, out chosenCategory);


            Item item = new Item() { Id = 1, Name = "Apple" };

            int a = 5;
            int b = a;
            
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
