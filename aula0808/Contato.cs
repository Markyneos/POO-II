

internal class Contato(string nome, string numerotelefone, string apelido, int quantodeve)
{
    public string Nome { get; set; } = nome;
    public string NumeroTelefone { get; set; } = numerotelefone;
    public string Apelido { get; set; } = apelido;
    public int QuantoDeve { get; set; } = quantodeve;

    // public Contato(string nome, string numero, string apel, int quantoDeve)
    // {
    //     Nome = nome;
    //     NumeroTelefone = numero;
    //     Apelido = apel;
    //     QuantoDeve = quantoDeve;
    // }
}

