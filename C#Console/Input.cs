

class Input
{
    public static void Hello()
    {
        Console.WriteLine("What is your name?: ");
        string username = Console.ReadLine();

        Console.WriteLine("Hello, " + username + "! Nice to meet you!");
    }
}