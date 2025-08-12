internal class Program
{
    static void Main(string[] args)
    {
        Contato c01 = new Contato("Marco A.", "123", "Marco", 0);
        Contato c02 = new Contato("Hugo", "123", "Hugo B.", 100);
        Contato c03 = new Contato("Kaiky", "123", "Kaiky V.", 200);

        AgendaTelefonica ag = new();

        ag.InserirContato(c01);
        ag.InserirContato(c02);
        ag.InserirContato(c03);

        Console.WriteLine(ag.BuscarContato("Marco A.").Apelido);
        Console.WriteLine($"Minha agenda tem {ag.QtdContatos()} contatos");
    }
}
