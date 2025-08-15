using System;

namespace lisex2;

class Helicopter : IFlyingTransport
{
    public void Fly(string origin, string destination, int passegers)
    {
        Console.WriteLine($"Estou voando.\nO: {origin} / D: {destination} / QtdP: {passegers}");
    }
}
