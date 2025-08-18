using System;

namespace lisex2;

class Treinamento
{
    public void Treinar(Militar[] m)
    {
        foreach (Militar mi in m)
        {
            mi.Operacao();
        }
    }
}
