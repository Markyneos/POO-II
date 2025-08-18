using System;

class ProfHorista : Professor
{
    private double _valorHora;
    public double ValorHora { get => _valorHora; }
    public ProfHorista(string nome, int matricula, int cargaHoraria, double valorHora) : base(nome, matricula, cargaHoraria)
    {
        _valorHora = valorHora;
    }

    public override void CalcularBeneficio()
    {
        Beneficio = _valorHora * CargaHoraria;
    }
}
