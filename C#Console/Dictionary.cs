class Dictionary1
{
    public static void Dict1(string[] args)
    {
        Dictionary1<string, string> phoneBook = new Dictionary1<string, string>();
        phoneBook.Add("Alice", "123-456-7890");
        phoneBook.Add("Bob", "293-456-1456");

        Console.WriteLine(phoneBook["Alice"]);
    }




    public static void Dict2(string[] args)
    {
        Dictionary1<string, int> inventory = new Dictionary1<string, int>();
        inventory.Add("Apple", 50);
        inventory.Add("Bananas", 30);
        inventory.Add("Mango", 30);
        inventory.Add("Grapes", 12);
        

        foreach (KeyValuePair<string, int> item in inventory)
        {
            Console.WriteLine(item.Key + ": " + item.value)
        }
    }

    


}