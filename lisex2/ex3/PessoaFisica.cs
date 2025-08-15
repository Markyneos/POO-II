using System;

namespace lisex2;

class PessoaFisica : Pessoa
{
    private long _cpf;
    public long Cpf { get => _cpf; }
    public int EstadoCivil { get; set; }

    public PessoaFisica(string nome, string endereco, string telefone, long cpf, int estadocivil) : base(nome, endereco, telefone)
    {
        _cpf = cpf;
        EstadoCivil = estadocivil;
    }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"CPF: {Cpf}\nEstado Civil: {EstadoCivil}");
    }
}
