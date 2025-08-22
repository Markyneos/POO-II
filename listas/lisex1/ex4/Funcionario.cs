using System;

namespace lisex1;

class Funcionario
{
    private int _matricula;
    public int Matricula { get => _matricula; }
    public string Nome { get; set; }
    public string CargoAtual { get; set; }
    private double _salarioAtual;
    public double SalarioAtual { get => _salarioAtual; }

    public Funcionario(int matricula, string nome, string cargo, double salario)
    {
        _matricula = matricula;
        Nome = nome;
        CargoAtual = cargo;
        _salarioAtual = salario;
    }

    public void Cadastrar() => Console.WriteLine("Usuário cadastrado");

    public void Consultar() => Console.WriteLine("Usuário consultado");

    public void AtualizarSalario(double novoSalario) => _salarioAtual = novoSalario;

    public void ListarDependentes()
    {
        Console.WriteLine("Listando dependentes.");
    }
}
