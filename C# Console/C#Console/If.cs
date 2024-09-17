

class If
{
    public static void Numbers(int number)
    {
        
        if (number > 0)
        {
            Console.WriteLine("Your number is positive.");
        }
        else if (number < 0)
        {
            Console.Write("Your number is negative.");
        }
        else
        {
            Console.WriteLine("Your number is zero.");
        }
    }

    public static void Health(int health)
    {
        if (health > 75)
        {
            Console.WriteLine("Player is in great condition!");
        }
        else if (health > 50)
        {
            Console.WriteLine("Player is in good condition.");
        }
        else if (health > 25)
        {
            Console.WriteLine("Player is in bad condition.");
        }
        else if (health > 0)
        {
            Console.WriteLine("Player is in critical condition!");
        }
        else
        {
            Console.WriteLine("Player is dead");
        }
    }
}