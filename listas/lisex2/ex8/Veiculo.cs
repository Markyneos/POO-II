using System;

namespace lisex2;

abstract class Veiculo
{
    public abstract void ListarVerificacoes(string[] verificacoes);
    public abstract void Ajustar();
    public abstract void Limpar();
}
