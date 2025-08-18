using System;

namespace lisex2;

abstract class ContaDeBanco
{
    private int _numero;
    public int Numero { get => _numero; }
    protected double _saldo;
    public double Saldo { get => _saldo; }

    public ContaDeBanco(int numero, double saldoInicial)
    {
        _saldo = saldoInicial;
        _numero = numero;
    }

    protected void contaDeBanco()
    {
        int opcao = 1;
        while (opcao > 0)
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1. Depositar\n2. Sacar\n3. Mostrar o saldo\n0. Sair");
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
            }
        }
    }
    public void Deposito(double qtd)
    {
        _saldo += qtd;
    }
    public virtual bool Retirada(double qtd)
    {
        if (qtd <= _saldo)
        {
            _saldo -= qtd;
            return true;
        }
        else
        {
            Console.WriteLine("Não pode retirar mais do que se tem.");
            return false;
        }
    }

    public abstract void MostraSaldo();
}
