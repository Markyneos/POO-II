using System;

namespace lisex2;

class PesoIdealHomem : PesoIdealPessoa
{
    public override double GetPesoIdeal(double altura)
    {
        return (72.7 * altura) - 58;
    }
}
