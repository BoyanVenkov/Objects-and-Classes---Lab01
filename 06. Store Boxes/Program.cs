class Program
{
    class Item
    {
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

    }
    class Box
    {
        public Box(int serialNumber, string itemName, int itemQuantity, double boxPrice, double itemPrice)
        {
            SerialNumber = serialNumber;
            ItemName = itemName;
            ItemQuantity = itemQuantity;
            BoxPrice = boxPrice;
            ItemPrice = itemPrice;
        }

        public int SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public double BoxPrice { get; set; }
        public double ItemPrice { get; set; }

    }
    static void Main()
    {
        List<Box> boxes = new List<Box>();
        List<Item> items = new List<Item>();
        string[] input = Console.ReadLine().Split().ToArray();
        while (true)
        {

            if (input[0] == "end")
            {
                break;
            }
            int serialNumber = int.Parse(input[0]);
            string itemName = input[1];
            int itemQuantity = int.Parse(input[2]);
            double itemPrice = double.Parse(input[3]);
            double boxPrice = itemQuantity * itemPrice;
            Item item = new Item(itemName, itemPrice);
            Box box = new Box(serialNumber, itemName, itemQuantity, boxPrice, itemPrice);
            boxes.Add(box);
            items.Add(item);
            input = Console.ReadLine().Split().ToArray();
        }
        boxes = boxes.OrderByDescending(b => b.BoxPrice).ToList();
        foreach (var box in boxes)
        {
            Console.WriteLine(box.SerialNumber);
            Console.WriteLine($"-- {box.ItemName} - ${box.ItemPrice:f2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.BoxPrice:f2}");
        }
    }
}