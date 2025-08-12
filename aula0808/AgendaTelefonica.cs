internal class AgendaTelefonica
{
    public Dictionary<string, Contato> Agenda { get; set; }

    public AgendaTelefonica() => Agenda = [];
    //public AgendaTelefonica() => Agenda = new Dictionary<string, Contato>;
    //public AgendaTelefonica() {
    //Agenda = new Dictionary<string, Contato>;
    //}

    public void InserirContato(Contato contato)
    {
        Agenda.Add(contato.Nome, contato);
    }

    public Contato BuscarContato(string nome)
    {
        return Agenda[nome];
    }

    public int QtdContatos()
    {
        return Agenda.Count();
    }
}
