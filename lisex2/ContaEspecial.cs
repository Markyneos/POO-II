using System;

namespace lisex2;

class ContaEspecial : ContaDeBanco, Capitalizacao
{
    public double Limite { get; set; }
    public double Premio { get; set; }

    public ContaEspecial(int numero, double saldoInicial, double limiteInicial) : base(numero, saldoInicial)
    {
        Limite = limiteInicial;
    }

    public void contaEspecial()
    {
        int opcao = 1;
        while (opcao > 0)
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1. Depositar\n2. Sacar\n3. Mostrar o saldo\n4. Calcular prêmio\n0. Sair");
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite a quantidade que deseja depositar: ");
                    double qtd = Convert.ToDouble(Console.ReadLine());
                    Deposito(qtd);
                    break;
                case 2:
                    Console.WriteLine("Digite a quantidade que deseja sacar: ");
                    qtd = Convert.ToDouble(Console.Read());
                    Retirada(qtd);
                    break;
                case 3:
                    MostraSaldo();
                    break;
                case 0:
                    Console.WriteLine("Tchau!");
                    break;
                case 4:
                    Console.WriteLine("Digite o valor do prêmio (eu não sei o que é um prêmio, desculpa, professor): ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    CalculaPremio(valor);
                    break;
            }
        }
    }

    public override void MostraSaldo()
    {
        Console.WriteLine($"Saldo: {Saldo}");
    }

    public void CalculaPremio(double premio)
    {
        Premio = premio;
    }
}
