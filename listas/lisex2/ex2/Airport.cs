using System;

namespace lisex2;

class Airport
{
    public IFlyingTransport? Vehicle { get; set; }

    public bool Accept(IFlyingTransport flying, string o, string d, int p)
    {
        if (Vehicle != null)
        {
            Console.WriteLine("Airport ocupado");
            return false;
        }
        Vehicle = flying;
        Vehicle.Fly(o, d, p);
        return true;
    }

    public void Clean()
    {
        Vehicle = null;
    }
}
