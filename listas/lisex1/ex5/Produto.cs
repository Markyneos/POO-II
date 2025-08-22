using System;

namespace lisex1;

class Produto
{
    public string Nome { get; set; }
    private double _preco;
    public double Preco
    {
        get => _preco;
        set
        {
            _preco = value;
        }
    }
    public int Estoque { get; set; }

    public Produto(string nome, double preco, int estoque)
    {
        Nome = nome;
        _preco = preco;
        Estoque = estoque;
    }

    public void MudarPreco(double novoPreco) => _preco = novoPreco;

    public void VenderProduto(int quantidade)
    {
        if (quantidade > Estoque)
        {
            Console.WriteLine("Você não pode comprar mais produtos do que temos!");
        }
        else
        {
            Console.WriteLine($"Serão pagos R${Preco * Estoque:F2}");
            Estoque -= quantidade;
        }
    }

    public void ComprarProduto(int quantidade) => Estoque += quantidade;

}
