using System;

internal class Conta(double lim, int num, double sal)
{
    public double Limite { get; set; } = lim;
    public int Numero { get; set; } = num;
    public double Saldo { get; set; } = sal;

    public Cliente Dono;

    public void Sacar(double qtd)
    {
        if (VerificarTransacao(qtd))
        {
            Saldo -= qtd;
        }
    }

    public void Depositar(double valor) => Saldo += valor;

    public bool VerificarTransacao(double valor)
    {
        if (Saldo >= valor)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
