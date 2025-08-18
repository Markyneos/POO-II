using System;

namespace lisex2;

class Gryphon : IFlyingTransport
{
    public void Fly(string origin, string destination, int passengers)
    {
        Console.WriteLine($"Voando à moda antiga!!!\nO: {origin} / D: {destination} / QtdP: {passengers}");
    }
}
