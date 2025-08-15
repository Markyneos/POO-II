using System;

namespace lisex2;

class Airplane : IFlyingTransport
{
    public void Fly(string origin, string destination, int passengers)
    {
        Console.WriteLine($"Voa voa.\nO: {origin} / D: {destination} / QtdP: {passengers}");
    }
}
