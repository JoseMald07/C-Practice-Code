

using System.Runtime.InteropServices.Marshalling;

class Character
{
    public string name;
    public int health;
    public int strength;

    public static void Players()
    {
        Character player1 = new Character();
        player1.name = "Jose";
        player1.health = 100;
        player1.strength = 100;
        Console.WriteLine("Player 1 name here: " + player1.name);

        Character player2 = new Character();
        player2.name = "Bob";
        player2.health = 50;
        player2.strength = 50;
    }
}