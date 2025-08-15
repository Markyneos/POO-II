using System;

namespace lisex2;

class PesoIdealMulher : PesoIdealPessoa
{
    public override double GetPesoIdeal(double altura)
    {
        return (62.1 * altura) - 44.7;
    }
}
