using System;

namespace lisex2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual tipo de conta deseja criar(P/E)?: ");
        string conta = Console.ReadLine() ?? "";
        Console.WriteLine("Digite o número de sua conta: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o saldo inicial: ");
        double saldo = Convert.ToDouble(Console.ReadLine());
        if (conta == "P")
        {
            Console.WriteLine("Digite sua data de aniversário(Dia/Mês): ");
            string data = Console.ReadLine() ?? "";
            ContaPoupanca c1 = new ContaPoupanca(num, saldo, data);
            Console.WriteLine("Sua conta poupança foi criada com sucesso!");
            c1.contaPoupanca();
        }
        else
        {
            ContaEspecial c1 = new ContaEspecial(num, saldo, 300.00);
            Console.WriteLine("Sua conta especial foi criada com sucesso!");
            c1.contaEspecial();
        }
    }
}
