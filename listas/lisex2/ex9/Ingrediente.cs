using System;

namespace lisex2;

class Ingrediente
{
    public int IdIngrediente { get; set; }
    public Produto[] produtos;

    public Ingrediente()
    {
        produtos = new Produto[5];
    }
}
