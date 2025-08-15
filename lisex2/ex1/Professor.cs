using System;

abstract class Professor
{
    private string _nome;
    public string Nome { get { return _nome; } }
    private int _matricula;
    public int Matricula { get { return _matricula; } }
    public int CargaHoraria { get; set; }
    public double Beneficio { get; set; }

    public Professor(string nome, int matricula, int cargaHoraria)
    {
        _nome = nome;
        _matricula = matricula;
        CargaHoraria = cargaHoraria;
    }

    public Professor(string nome, int matricula, int cargaHoraria, double beneficio)
    {
        _nome = nome;
        _matricula = matricula;
        CargaHoraria = cargaHoraria;
        Beneficio = beneficio;
    }

    public abstract void CalcularBeneficio();

    public double getBeneficio() => Beneficio;
}
