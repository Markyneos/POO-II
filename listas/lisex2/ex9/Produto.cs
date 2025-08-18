using System;

namespace lisex2;

class Produto
{
    public int IdProduto { get; set; }
    public Ingrediente[] ingredientes;

    public Produto()
    {
        ingredientes = new Ingrediente[5];
    }
}
