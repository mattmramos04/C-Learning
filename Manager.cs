using System;
using System.Collections.Generic;

public class Manager : Wrestler
{
    public string ClientName;

    public override void CutPromo()
    {
        Console.WriteLine($"Ladies and Gentlement my name is {Name} and I am the manager for {ClientName}");
    }

    public Manager(string name, int age, string clientName) : base (name, age)
    {
        ClientName = clientName;
    }
}