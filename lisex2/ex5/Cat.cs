using System;

namespace lisex2;

class Cat : Animal, FourLegged, OxygenBreather
{
    public void Run(string destination)
    {
        Console.WriteLine("You reached your destination!");
    }

    public void Breath()
    {
        Console.WriteLine("You Inhale\nThen you exhale :)");
    }
}
