using System;

namespace lisex2;

class PesoIdealPrincipal
{
    static void Main(string[] args)
    {
        PesoIdealPessoa peso;
        Console.WriteLine("Digite seu sexo(M/F): ");
        string inp1 = Console.ReadLine() ?? "";
        if (inp1 == "M")
        {
            peso = new PesoIdealHomem();
        }
        else if (inp1 == "F")
        {
            peso = new PesoIdealHomem();
        }
        else
        {
            throw new ApplicationException("Deve-se inserir um caractere válido.");
        }
        Console.WriteLine("Insira sua altura: ");
        double inp2 = double.Parse(Console.ReadLine() ?? throw new ApplicationException("Deve-se inserir sua altura para o programa funcionar"));
        Console.WriteLine($"Seu peso ideal é: {peso.GetPesoIdeal(inp2):F2}");
    }
}
