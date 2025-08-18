using System;

class ProfDE : Professor
{
    public ProfDE(string nome, int matricula, int cargaHoraria, double beneficio) : base(nome, matricula, cargaHoraria, beneficio)
    {

    }

    public override void CalcularBeneficio()
    {
        Console.WriteLine($"Benefício do Professor DE: {Beneficio}");
    }
}
