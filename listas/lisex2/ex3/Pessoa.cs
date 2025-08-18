using System;

namespace lisex2;

abstract class Pessoa
{
    private string? _nome;
    public string Nome
    {
        get
        {
            if (_nome != null)
            {
                return _nome;
            }
            else
            {
                return "";
            }
        }
    }
    public string Endereco { get; set; }
    public string Telefone { get; set; }

    public Pessoa(string nome, string endereco, string telefone)
    {
        _nome = nome;
        Endereco = endereco;
        Telefone = telefone;
    }

    public Pessoa(string endereco, string telefone)
    {
        Endereco = endereco;
        Telefone = telefone;
    }

    public virtual void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}\nEndereço: {Endereco}\nTelefone: {Telefone}");
    }
}
