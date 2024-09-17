

using System.Globalization;

class Loops
{
    public static void ForLoops()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Iteration " + i);
        }
    }

    public static void EvenLoops()
    {
        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void HealthLoop()
    {
        int health = 100;
        while (health >= 0)
        {
            Console.WriteLine("Player is alive with health! " + health);
            health -= 10;
        }
    }

    public static void NestedLoops()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Iteration " + i);

            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("Iteration " + j);

                for (int k = 0; k <= 10; k++)
                {
                    Console.WriteLine("Iteration " + k);
                
                }
            }
        }
    }

    public static void DoWhile()
    {
        int number;
        do
        {
            Console.WriteLine("Enter a number greater than 0:");
            number = Convert.ToInt32(Console.ReadLine());
        }
        while (number >= 0);
        {
            Console.WriteLine("You entered: " + number);
        }
    }
}