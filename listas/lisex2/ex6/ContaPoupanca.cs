using System;

namespace lisex2;

class ContaPoupanca : ContaDeBanco, Capitalizacao
{
    private string _diaAniversario;
    public string DiaAniversario { get => _diaAniversario; }
    protected double _correcao = 0.045;
    public double Correcao { get => _correcao; set { _correcao = value; } }
    public double premio { get; set; }

    public ContaPoupanca(int numero, double saldoInicial, string aniversario) : base(numero, saldoInicial)
    {
        _diaAniversario = aniversario;
    }

    public void contaPoupanca()
    {
        int opcao = 1;
        while (opcao > 0)
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1. Depositar\n2. Sacar\n3. Mostrar o saldo\n4. Corrigir saldo\n5. Calcula prêmio\n0. Sair");
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
                case 4:
                    CorrigeSaldo();
                    Console.WriteLine("Saldo corrigido!");
                    break;
                case 5:
                    Console.WriteLine("Digite o valor do prêmio (eu não sei o que é um prêmio, desculpa, professor): ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    CalculaPremio(valor);
                    break;
                case 0:
                    Console.WriteLine("Tchau!");
                    break;
            }
        }
    }

    public void CorrigeSaldo()
    {
        _saldo = Saldo + (Saldo * Correcao);
    }

    public override void MostraSaldo()
    {
        Console.WriteLine($"Saldo: {Saldo}");
    }

    public void CalculaPremio(double premio)
    {
        this.premio = premio;
    }
}
