using System;

namespace lisex2;

class PessoaJuridica : Pessoa
{
    private long _cnpj;
    public long Cnpj { get => _cnpj; }
    public string RazaoSocial { get; set; }
    public string NomeRepresentante { get; set; }

    public PessoaJuridica(string endereco, string telefone, long cnpj, string razaoSocial, string nomeRepresentante) : base(endereco, telefone)
    {
        _cnpj = cnpj;
        RazaoSocial = razaoSocial;
        NomeRepresentante = nomeRepresentante;
    }

    public override void ExibirDados()
    {
        Console.WriteLine($"Endereço: {Endereco}\nTelefone: {Telefone}");
        Console.WriteLine($"CNPJ: {Cnpj}\nRazão Social: {RazaoSocial}\nNome Representante: {NomeRepresentante}");
    }
}
