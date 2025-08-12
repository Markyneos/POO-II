class Cliente
{
    public string nome { get; set; }
    public string endereco { get; set; }
    public string cpf { get; set; }

    public Cliente(string n, string e, string c)
    {
        this.nome = n;
        endereco = e;
        cpf = c;
    }
}
