using System;

namespace lisex2;

public interface IFlyingTransport
{
    public abstract void Fly(string origin, string destination, int passegers);
}
