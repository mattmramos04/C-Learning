using System;
using System.Collections.Generic;

class LearnSetGet
{
    public static void Main()
    {
        Wrestler w1 = new Wrestler();
        w1.Name = "Max";

        Wrestler w2 = new Wrestler();
        w2.Name = "Luna";

        //w1.Energy -= 10; because Energy is static so energy is shared amongst all Wrestler objects.

        w1.ShowStats(); // What will this show?
        w2.ShowStats(); // And this?
    }
}

public class Wrestler
{
    public string Name;
    public static int Energy = 100;

    public void ShowStats()
    {
        Console.WriteLine($"{Name} has {Energy} energy.");
    }

    /*private int damage = 50;
    public int Damage
    {
        get { return damage; }
    }
    private int health = 100;
    public int Health
    {
        get { return health; }
        set
        {
            if (value < 0)
                health = 0;
            else
                health = value;
        }
    }

    public string Name { get; set; }

    private int energy = 100;

    public int Energy
    {
        get { return energy; }
        set
        {
            if (value > 100)
                energy = 100;
            else if (value < 0)
                energy = 0;
            else
                energy = value;
        }
    }
    public Wrestler(string name, int startingEnergy, int startingHealth)
    {
        Name = name;
        Energy = startingEnergy;
        Health = startingHealth;
    }*/
}