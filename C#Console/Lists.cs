

class Lists
{
    public static void List1(String[] args)
    {
        List1<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");
        fruits.Add("Grape");
        fruits.Add("Mango");

        fruits.Remove("Banana");

        fruits.Insert(0, "Pineapple");
        
        for each (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}