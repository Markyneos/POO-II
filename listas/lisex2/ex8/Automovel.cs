using System;

namespace lisex2;

class Automovel : Veiculo
{
    public override void ListarVerificacoes(string[] verificacoes)
    {
        Console.WriteLine("Verificacoes:");
        foreach (string s in verificacoes)
        {
            Console.WriteLine(s);
        }
    }
    public override void Ajustar()
    {
        Console.WriteLine("Bicicleta ajustada");
    }
    public override void Limpar()
    {
        Console.WriteLine("Limpa como nova!");
    }

    public void MudarOleo()
    {
        Console.WriteLine("Óleo trocado!");
    }
}
