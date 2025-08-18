using System;

namespace lisex2;

class Oficina
{
    public Veiculo Proximo()
    {
        Random r = new Random();
        Automovel a = new Automovel();
        Bicicleta b = new Bicicleta();
        return r.Next(0, 2) == 0 ? a : b;
    }
    public void Manutencao(Veiculo v)
    {
        string[] ver = { "Verificação" };
        v.ListarVerificacoes(ver);
        v.Limpar();
        v.Ajustar();
        if (v.GetType() == typeof(Automovel))
        {
            ((Automovel)v).MudarOleo();
        }
    }
}
